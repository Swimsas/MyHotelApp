using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Room;
using MyHotelApp.Core.Models.User;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;
        public UserService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<UserReservationView?> GetReseravationByIdAsync(int id)
        {
            var reservation = await repository
                .GetByIdAsync<ReservationRoom>(id);

            if (reservation == null)
            {
                return null;
            }

            var room = await repository
               .GetByIdAsync<Room>(reservation.RoomId);

            
            
            return new UserReservationView() 
            {
                StartDate = reservation.CheckInDate,
                LeaveDate = reservation.CheckOutDate,
                Id = reservation.Id,
                UserId = reservation.UserId,
                IsApproved = reservation.IsApproved,
                Room = new RoomViewModel() 
                {
                    ImgUrl = room!.ImgUrl!,
                    Floor = room.FloorId,
                    Price = room.Price.ToString("F2"),
                    Id  = room.Id
                }
            };
        }

        public async Task<IEnumerable<UserReservationView>> GetUserReservationAsync(string userId)
        {
            var reservations = await repository.AllReadOnly<ReservationRoom>()
                .Where(r => r.UserId == userId)
                .Select(r => new UserReservationView() 
                {
                    Id = r.Id,
                    StartDate = r.CheckInDate,
                    LeaveDate = r.CheckOutDate,
                    UserName = r.User.UserName,
                    IsApproved = r.IsApproved,
                    Room = new RoomViewModel() 
                    {
                        Id = r.Room.Id,
                        Floor = r.Room.Floor.Id,
                        ImgUrl = r.Room.ImgUrl!,
                        Type = r.Room.RoomType.Name,
                        View = r.Room.ViewType.Name,
                        Price = r.Room.Price.ToString()
                    }
                })
                .ToListAsync();

            return reservations;
        }

        public async Task DeleteReservation(int id) 
        {
            await repository.DeleteAsync<ReservationRoom>(id);
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserReservationView>> AllReservationsAsync()
        {
            var reservations = await repository.AllReadOnly<ReservationRoom>()
                .Select(r => new UserReservationView()
                {
                    Id = r.Id,
                    StartDate = r.CheckInDate,
                    LeaveDate = r.CheckOutDate,
                    UserName = r.User.UserName,
                    IsApproved = r.IsApproved,
                    Room = new RoomViewModel()
                    {
                        Id = r.Room.Id,
                        Floor = r.Room.Floor.Id,
                        ImgUrl = r.Room.ImgUrl!,
                        Type = r.Room.RoomType.Name,
                        View = r.Room.ViewType.Name,
                        Price = r.Room.Price.ToString()
                    }
                })
                .ToListAsync();

            return reservations;
        }

        public async Task<int> GetCountOfReservationsForApproveAsync()
        {
            var reservations = await repository.AllReadOnly<ReservationRoom>()
                .Where(r => r.IsApproved == false)
                .ToArrayAsync();


            return reservations.Length;
        }

        public async Task ApproveReservationAsync(int id)
        {
            var reservation = await repository.GetByIdAsync<ReservationRoom>(id);
            reservation!.IsApproved = true;

            await repository.SaveChangesAsync();
        }
    }
}
