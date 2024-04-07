using Microsoft.AspNetCore.Mvc;

namespace MyHotelApp.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult AllBookings()
        {
              
            return View();
        }
    }
}
