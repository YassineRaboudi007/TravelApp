using TravelApp.Flight.Domain;
using TravelApp.Flight.ExternalApis.SaberDev.ApiClients;
using TravelApp.Shared;

namespace TravelApp.Flight.FlightsQuery
{
    public class FlightsQueryService : IFlightsQueryService
    {
        private readonly ISaberDevFlightsApiClient _saberDevFlightsApiClient;

        public FlightsQueryService(ISaberDevFlightsApiClient saberDevFlightsApiClient)
        {
            _saberDevFlightsApiClient = saberDevFlightsApiClient;
        }

        public async Task<Result<List<FlightsQueryResponse>, BaseError>> GetFlightsAsync(string origin, string destination, DateTime departueDate, DateTime returnDate)
        {
            var errors = ValidateInput(origin, destination, departueDate, returnDate);

            if (errors != null)
            {
                return errors;
            }

            Result<List<FlightsQueryResponse>?, BaseError> parsedRespone = await _saberDevFlightsApiClient.GetSaberDevFlightQueryAsync(origin, destination, departueDate, returnDate);
            // In case we have multiple apis we can unitfy their result in the same Object type and then add an 
            // aggregation service to call and orchestract the combined result
            return parsedRespone;
        }

        private BaseError? ValidateInput(string origin, string destination, DateTime departueDate, DateTime returnDate)
        {
            if (origin.Length != 3)
            {
                return FlightsDomainErrors.LocationLengthMustBeThree;
            }

            if (destination.Length != 3)
            {
                return FlightsDomainErrors.LocationLengthMustBeThree;
            }

            if (departueDate < DateTime.UtcNow)
            {
                return FlightsDomainErrors.InvalidDepartureDate;
            }

            if (returnDate < departueDate)
            {
                return FlightsDomainErrors.ReturnDateLowerThanDeparture;
            }

            return null;
        }
    }
}
