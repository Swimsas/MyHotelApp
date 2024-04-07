using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyHotelApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
