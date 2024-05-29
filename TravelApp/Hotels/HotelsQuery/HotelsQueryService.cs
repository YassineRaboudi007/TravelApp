using TravelApp.Flight.FlightsQuery;
using TravelApp.Shared;
using TravelApp.Hotels.Domain;
using TravelApp.Hotels.ExternalApis.SabreDev.Services;

namespace TravelApp.Hotels.HotelsQuery
{
    public class HotelsQueryService : IHotelsQueryService
    {
        private readonly ISabreDevHotelsApiClient _sabreDevHotelsApiClient;

        public HotelsQueryService(ISabreDevHotelsApiClient sabreDevHotelsApiClient)
        {
            _sabreDevHotelsApiClient = sabreDevHotelsApiClient;
        }

        public async Task<Result<SimplifiedHotelInfo, BaseError>> GetHotelsAsync(string airportCode, DateTime checkIn, DateTime checkOut)
        {
            var errors = ValidateInput(airportCode, checkIn, checkOut);

            if (errors != null)
            {
                return errors;
            }

            // We can add layer of cahcing here for api calls with invalidation logic

            Result<SimplifiedHotelInfo, BaseError> parsedRespone = await _sabreDevHotelsApiClient.GetSabreHotelsSearchResultAsync(airportCode, checkIn, checkOut);
            // In case we have multiple apis we can unitfy their result in the same Object type and then add an 
            // aggregation service to call and orchestract the combined result
            return parsedRespone;
  
        }

        private BaseError? ValidateInput(string airportCode, DateTime checkIn, DateTime checkOut)
        {
            if (airportCode.Length != 3)
            {
                return HotelsDomainErrors.AirportCodeLengthMustBeThree;
            }

            if (checkIn < DateTime.UtcNow)
            {
                return HotelsDomainErrors.CheckInDateMustBeGreaterThanToday;
            }

            if (checkOut < checkIn)
            {
                return HotelsDomainErrors.CheckOutDateMustBeSuperiourThenCheckIn;
            }
            return null;
        }
    }
}
