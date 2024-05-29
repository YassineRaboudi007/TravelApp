using TravelApp.Flight.FlightsQuery;
using TravelApp.Shared;

namespace TravelApp.Flight.ExternalApis.SaberDev.ApiClients
{
    public interface ISaberDevFlightsApiClient
    {
        Task<Result<List<FlightsQueryResponse>?, BaseError>> GetSaberDevFlightQueryAsync(string origin, string destination, DateTime departueDate, DateTime returnDate);
    }
}
