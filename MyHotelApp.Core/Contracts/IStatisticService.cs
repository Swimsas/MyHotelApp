using MyHotelApp.Core.Models.Statistics;

namespace MyHotelApp.Core.Contracts
{
    public interface IStatisticService
    {
        Task<StatisticServiceModel> TotalAsync();
    }
}
