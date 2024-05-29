using TravelApp.Shared;

namespace TravelApp.Flight.Domain
{
    public class FlightsDomainErrors
    {
        public static BaseError InvalidDepartureDate = new BaseError("InvalidDepartureDate", "Invalid Departure Date");
        public static BaseError ReturnDateLowerThanDeparture = new BaseError("ReturnDateLowerThanDeparture", "Return Date Lower Than Departure");
        public static BaseError LocationLengthMustBeThree = new BaseError("LocationLengthMustBeThree", "Location Length Must Be Three");
    }
}
