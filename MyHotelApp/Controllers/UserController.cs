using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;
using System.Security.Claims;

namespace MyHotelApp.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService service;

        public UserController(IUserService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.Id();
            
            var model = await service.GetUserReservationAsync(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            var model = await service.GetReseravationByIdAsync(id);

            if (model == null) 
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id) 
        {
            var reservationToDelete = await service.GetReseravationByIdAsync(id);

            if (reservationToDelete == null) 
            {
                return BadRequest();
            }

            var userId = User.Id();

            if (reservationToDelete.UserId != userId)
            {
                return Unauthorized();
            }

            await service.DeleteReservation(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
