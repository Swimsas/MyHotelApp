﻿using MyHotelApp.Core.Models.User;

namespace MyHotelApp.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserReservationView>> GetUserReservationAsync(string userId);

        Task<UserReservationView?> GetReseravationByIdAsync(int id);

        Task DeleteReservation(int id);
    }
}
