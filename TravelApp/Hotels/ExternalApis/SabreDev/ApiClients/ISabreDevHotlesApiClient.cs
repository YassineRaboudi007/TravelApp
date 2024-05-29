using TravelApp.Flight.FlightsQuery;
using TravelApp.Hotels.HotelsQuery;
using TravelApp.Shared;

namespace TravelApp.Hotels.ExternalApis.SabreDev.Services;

public interface ISabreDevHotelsApiClient
{
    Task<Result<SimplifiedHotelInfo, BaseError>> GetSabreHotelsSearchResultAsync(string airportCode, DateTime checkIn, DateTime checkOut);
}
