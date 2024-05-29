namespace TravelApp.Controllers.FlightController.Dtos
{
    public class FlightSearchRequestDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
