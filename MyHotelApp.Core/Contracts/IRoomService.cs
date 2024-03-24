using MyHotelApp.Core.Models.Room;

namespace MyHotelApp.Core.Contracts
{
    public interface IRoomService
    {
        Task<BookRoomSearchModel> GetAllRoomsBySearch(int viewType, int roomType, int sorting, int currentPage, int roomsPerPage, int totalRoomsCount,DateTime startDate, DateTime leaveDate);

        Task<IEnumerable<ViewsCategoryModel>> GetViewCategories();

        Task<IEnumerable<RoomTypeCategoryModel>> GetRoomTypeCategories();

        Task<int> BookRoom(int id, string startDate, string leaveDate,string userId);
    }
}
