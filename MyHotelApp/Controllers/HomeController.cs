using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Models;
using System.Diagnostics;

namespace MyHotelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IIndexService service;

        public HomeController(
            IIndexService _service,
            ILogger<HomeController> _logger)
        {
            service = _service;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await service.GetThreeRoomsAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
