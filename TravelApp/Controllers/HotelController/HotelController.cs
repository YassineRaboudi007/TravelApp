using Microsoft.AspNetCore.Mvc;
using TravelApp.Controllers.FlightController;
using TravelApp.Controllers.HotelController.Dtos;
using TravelApp.Flight.FlightsQuery;
using TravelApp.Hotels.HotelsQuery;

namespace TravelApp.Controllers.HotelController
{

    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly IHotelsQueryService _hotelsQueryService;

        public HotelController(ILogger<HotelController> logger, IHotelsQueryService hotelsQueryService)
        {
            _logger = logger;
            _hotelsQueryService = hotelsQueryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelsPerRegion(
        [FromQuery] string AirportZone,
        [FromQuery] DateTime CheckIn,
        [FromQuery] DateTime CheckOut)
        {
            try
            {
                var result = await _hotelsQueryService.GetHotelsAsync(AirportZone, CheckIn, CheckOut);
                return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Errors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return BadRequest("Some error occurred while processing your request.");
            }
        }
    }
}

