using Microsoft.AspNetCore.Authorization;
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
            var userId = GetUserId();
            
            var model = await service.GetUserReservationAsync(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            var model = await service.GetReseravationByIdAsync(id);

            if (model == null) 
            {
                return StatusCode(400);
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

            var userId = GetUserId();

            if (reservationToDelete.UserId != userId)
            {
                return Unauthorized();
            }

            await service.DeleteReservation(id);

            return RedirectToAction(nameof(Index));
        }
        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
