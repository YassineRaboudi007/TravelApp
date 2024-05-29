using Microsoft.AspNetCore.Mvc;
using TravelApp.Controllers.FlightController.Dtos;
using TravelApp.Flight.FlightsQuery;
using TravelApp.Shared;

namespace TravelApp.Controllers.FlightController
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly ILogger<FlightsController> _logger;
        private readonly IFlightsQueryService _flightsQueryService;

        public FlightsController(ILogger<FlightsController> logger, IFlightsQueryService flightsQueryService)
        {
            _logger = logger;
            _flightsQueryService = flightsQueryService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetFlights(
        [FromQuery] string origin,
        [FromQuery] string destination,
        [FromQuery] DateTime departureDate,
        [FromQuery] DateTime returnDate)
        {
            try
            {
                var result = await _flightsQueryService.GetFlightsAsync(origin, destination, departureDate, returnDate);
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
