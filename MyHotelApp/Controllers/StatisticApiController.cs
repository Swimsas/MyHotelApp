using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelApp.Core.Contracts;

namespace MyHotelApp.Controllers
{
    [Route("api/statistic")]
    [ApiController]
    public class StatisticApiController : ControllerBase
    {
        private readonly IStatisticService service;

        public StatisticApiController(IStatisticService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistic() 
        {
            var result = await service.TotalAsync();

            return Ok(result);
        }
    }
}
