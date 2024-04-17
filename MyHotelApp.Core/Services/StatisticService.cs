using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Statistics;
using MyHotelApp.Infrastructure.Common;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Core.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IRepository repository;
        private readonly UserManager<IdentityUser> userManager;

        public StatisticService(IRepository _repository, UserManager<IdentityUser> _userManager) 
        {
            repository = _repository;
            userManager = _userManager;
        }
        public async Task<StatisticServiceModel> TotalAsync()
        {
            var model = new StatisticServiceModel();

            model.TotalBookings = await repository
                .AllReadOnly<ReservationRoom>()
                .CountAsync();

            var avgRating = await repository
                .AllReadOnly<Review>()
                .AverageAsync(r => r.Rating);

            model.AvgRating = Math.Round((decimal)avgRating, 2);


            model.TotalUsers = await userManager.Users.CountAsync();

            return model;
        }
    }
}
