using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MyHotelApp.Core.Constants.AdministratorConstants;

namespace MyHotelApp.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminRole)]
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        
    }
}
