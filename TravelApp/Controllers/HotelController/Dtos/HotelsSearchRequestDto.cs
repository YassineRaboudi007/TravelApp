namespace TravelApp.Controllers.HotelController.Dtos
{
    public class HotelsSearchRequestDto
    {
        public string AirportZone { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
