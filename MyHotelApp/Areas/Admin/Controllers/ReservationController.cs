using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;

namespace MyHotelApp.Areas.Admin.Controllers
{
    public class ReservationController : AdminBaseController
    {
        private readonly IUserService service;

        public ReservationController(IUserService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> AllReservations()
        {
            var reservations = await service.AllReservationsAsync();

            return View(reservations);
        }

        [HttpPost]
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var reservation = await service.GetReseravationByIdAsync(id);

            if (reservation == null)
            {
                return BadRequest();
            }

            await service.ApproveReservationAsync(reservation.Id);

            return RedirectToAction(nameof(AllReservations));
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

            await service.DeleteReservation(id);

            return RedirectToAction(nameof(AllReservations));
        }
    }
}
