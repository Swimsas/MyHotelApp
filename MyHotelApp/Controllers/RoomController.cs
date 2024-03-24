﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;
using MyHotelApp.Core.Models.Room;
using System.Globalization;
using System.Security.Claims;

namespace MyHotelApp.Controllers
{
    [Authorize]
    public class RoomController : Controller
    {
        private readonly IRoomService service;

        public RoomController(IRoomService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> BookRoom([FromQuery]BookRoomSearchModel model)
        {
            model.ViewsCategoryModels = await service.GetViewCategories();
            model.RoomTypesCategoryModels = await service.GetRoomTypeCategories();

            if (model.StartDate != null && model.LeaveDate != null) 
            {
                model.IsFirstLoad = false;

                DateTime startDate = DateTime.Now;
                DateTime leaveDate = DateTime.Now;

                if (DateTime.TryParseExact(
                    model.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate)  
                    &&
                    DateTime.TryParseExact(
                        model.LeaveDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out leaveDate))
                {
                    if (startDate < DateTime.Now.Date || startDate >= leaveDate) 
                    {
                        ModelState.AddModelError("startDate", "Start date must be today or in present and before leaving date");
                    }
                }
                else 
                {
                    ModelState.AddModelError(nameof(model.StartDate), "Use corect date format");
                }

                if (!ModelState.IsValid)
                {
                    model.IsFirstLoad = true;
                    return View(model);
                }

                var newModel = await service.GetAllRoomsBySearch(
                    model.ViewType,
                    model.RoomType,
                    model.Sorting,
                    model.CurrentPage,
                    model.RoomsPerPage,
                    model.TotalRoomsCount,
                    startDate,
                    leaveDate);

                model.RoomViewModels = newModel.RoomViewModels;
                model.TotalRoomsCount = newModel.TotalRoomsCount;
            }
                
              
            
            return View(model);
        }

        public async Task<IActionResult> ProceedRoomBooking(int id, string startDate, string leaveDate) 
        {
            var userid = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;

            int result =await service.BookRoom(id,startDate,leaveDate,userid);

            if (result == 0)
            {
                return StatusCode(400);
            }


            return RedirectToAction("Index","Home");
        }

    }
}
