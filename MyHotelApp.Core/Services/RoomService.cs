using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Room;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data.Model;
using System.Globalization;
using System.Security.Claims;

namespace MyHotelApp.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository repository;
        public RoomService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> BookRoom(int id, string startDateString, string leaveDateString, string userId)
        {
            DateTime startDate = DateTime.Now;
            DateTime leaveDate = DateTime.Now;

            if (DateTime.TryParseExact(startDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate) && DateTime.TryParseExact(leaveDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out leaveDate))
            {
                if (startDate < DateTime.Now.Date || startDate >= leaveDate)
                {
                    return  0;
                }
            }
            else
            {
                return 0;
            }

            var room = await repository
                .AllReadOnly<Room>()
                .Where(r => !repository
                .AllReadOnly<ReservationRoom>()
                .Any(b => b.RoomId == r.Id && (
                (startDate >= b.CheckInDate && startDate < b.CheckOutDate) ||
                (leaveDate > b.CheckInDate && leaveDate <= b.CheckOutDate) ||
                (startDate <= b.CheckInDate && leaveDate >= b.CheckOutDate)
                )))
                .FirstOrDefaultAsync(r => r.Id == id);

            if (room == null && userId == string.Empty )
            {
                return 0;
            }

            var roomReservation = new ReservationRoom 
            {
                RoomId = room!.Id,
                CheckInDate = startDate,
                CheckOutDate = leaveDate,
                UserId = userId
            };

            await repository.AddAsync<ReservationRoom>(roomReservation);
            await repository.SaveChangesAsync();

            return 1;
        }

        public async Task<BookRoomSearchModel> GetAllRoomsBySearch(int viewType, int roomType, int sorting, int currentPage, int roomsPerPage, int totalRoomsCount, DateTime startDate, DateTime leaveDate)
        {
            if (startDate < DateTime.Now.Date || startDate >= leaveDate) 
            {
                return new BookRoomSearchModel();
            }

            var roomsQuery = repository
                .AllReadOnly<Room>()
                .Where(r => !repository
                .AllReadOnly<ReservationRoom>()
                .Any(b => b.RoomId == r.Id && (
                (startDate >= b.CheckInDate && startDate < b.CheckOutDate) ||
                (leaveDate > b.CheckInDate && leaveDate <= b.CheckOutDate) ||
                (startDate <= b.CheckInDate && leaveDate >= b.CheckOutDate)
                )));
                

                    

            if (viewType != 0) 
            {
                roomsQuery = roomsQuery.Where(r => r.ViewTypeId == viewType);
            }
            
            if (roomType != 0) 
            {
                roomsQuery = roomsQuery.Where(r => r.RoomTypeId == roomType);
            }

            if (sorting == 0) 
            { 
                roomsQuery = roomsQuery.OrderByDescending(r => r.Price);
            }
            else
            {
                roomsQuery = roomsQuery.OrderByDescending(r => r.FloorId);
            }

            var rooms =  await roomsQuery
                .Skip((currentPage - 1 ) * roomsPerPage)
                .Take(roomsPerPage)
                .Select(r => new RoomViewModel 
                {   Id = r.Id,
                    Floor = r.FloorId,
                    View = r.ViewType.Name,
                    Type = r.RoomType.Name,
                    ImgUrl = r.ImgUrl!,
                    Price = r.Price.ToString("F2")
                })
                .ToListAsync();

            int totalRoom = await roomsQuery.CountAsync();

            var bookRoomSearchModel = new BookRoomSearchModel() 
            {
                RoomViewModels = rooms,
                TotalRoomsCount = totalRoom
            };


            return bookRoomSearchModel;
        }

        public async Task<IEnumerable<RoomTypeCategoryModel>> GetRoomTypeCategories()
        {
            var roomTypeCategoriesQuery = repository.AllReadOnly<RoomType>();

            var roomTypeCategories = await roomTypeCategoriesQuery
                .Select(c => new RoomTypeCategoryModel() 
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return roomTypeCategories;
        }


        public async Task<IEnumerable<ViewsCategoryModel>> GetViewCategories()
        {
            var viewCategoriesQuery = repository.AllReadOnly<ViewType>();

            var viewCategories =await viewCategoriesQuery
                .Select(c => new ViewsCategoryModel() 
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
                

            return viewCategories;
        }

       
    }
}
