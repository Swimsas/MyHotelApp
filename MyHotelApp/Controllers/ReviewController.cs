using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Review;
using System.Security.Claims;

namespace MyHotelApp.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewService service;

        public ReviewController(IReviewService _service)
        {
            service = _service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await service.AllReviewsAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddReview() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewViewModel model) 
        {
            if (ModelState.IsValid == false) 
            {
                return View(model);
            }

            if (await service.CanUserWriteReviewAsync(User.Id()) == false)
            {
                return BadRequest();
            }

            await service.AddReviewAsync(model,User.Id());

            return RedirectToAction(nameof(All));
        }
    }
}
