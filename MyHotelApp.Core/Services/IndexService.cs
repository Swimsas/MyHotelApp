using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Home;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Core.Services
{
    public class IndexService : IIndexService
    {
        private readonly IRepository repository;

        public IndexService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<RoomIndexServiceModel>> GetThreeRoomsAsync()
        {
            Random random = new Random();
            int startId = random.Next(0, 43);

            return await repository
                .AllReadOnly<Room>()
                .Where(r => r.Id > startId)
                .Take(3)
                .Select(r => new RoomIndexServiceModel 
                {
                    Floor = r.Floor.Name,
                    View = r.ViewType.Name,
                    RoomType = r.RoomType.Name,
                    Url = r.ImgUrl!
                })
                .ToArrayAsync();
        }
    }
}
