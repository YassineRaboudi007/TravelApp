namespace TravelApp.Flight.FlightsQuery
{
    public class FlightsQueryResponse
    {
        public string AirlineCode { get; set; }
        public int FlightNumber { get; set; }
        public string DepartureDateTime { get; set; }
        public string ReturnDateTime { get; set; }
        public double TotalAmount { get; set; }
        public double Taxes { get; set; }
        public double BaseAmount { get; set; }
        public int SeatsRemaining { get; set; }
    }
}
