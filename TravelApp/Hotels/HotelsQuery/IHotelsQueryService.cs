using TravelApp.Flight.FlightsQuery;
using TravelApp.Shared;

namespace TravelApp.Hotels.HotelsQuery
{
    public interface IHotelsQueryService
    {
        Task<Result<SimplifiedHotelInfo, BaseError>> GetHotelsAsync(string airportCode, DateTime checkIn, DateTime checkOut);
    }
}
