using MyHotelApp.Core.Models.Home;
using MyHotelApp.Infrastructure.Common;

namespace MyHotelApp.Core.Contracts
{
    public interface IIndexService
    {
        Task<IEnumerable<RoomIndexServiceModel>> GetThreeRoomsAsync();
    }
}
