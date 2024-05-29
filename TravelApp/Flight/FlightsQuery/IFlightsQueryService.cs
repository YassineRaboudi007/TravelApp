using TravelApp.Shared;

namespace TravelApp.Flight.FlightsQuery
{
    public interface IFlightsQueryService
    {
        Task<Result<List<FlightsQueryResponse>, BaseError>> GetFlightsAsync(string origin, string destination, DateTime departueDate, DateTime returnDate);
    }
}
