using Microsoft.AspNetCore.Mvc;

namespace MyHotelApp.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        [HttpGet]
        public IActionResult DashBoard()
        {
              
            return View();
        }
    }
}
