using Microsoft.AspNetCore.Mvc;

namespace MyHotelApp.Areas.Admin.Component
{
    public class AdminMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
