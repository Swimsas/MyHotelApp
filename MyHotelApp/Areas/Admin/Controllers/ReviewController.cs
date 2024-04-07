using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;

namespace MyHotelApp.Areas.Admin.Controllers
{
    public class ReviewController : AdminBaseController
    {
        private readonly IReviewService service;

        public ReviewController(IReviewService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await service.AdminAllReviewsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Reviewed(int id) 
        {
            var review = await service.IsThereReviewAsync(id);

            if (review == false)
            {
                return BadRequest();
            }

            await service.ReviewedReviewAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            var model = await service.GetReviewByIdAsync(id);

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (await service.IsThereReviewAsync(id) == false) 
            {
                return BadRequest();
            }

            await service.DeleteReviewAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
