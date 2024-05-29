using TravelApp.Shared;

namespace TravelApp.Hotels.Domain
{
    public class HotelsDomainErrors
    {
        public static BaseError AirportCodeLengthMustBeThree = new BaseError("AirportCodeLengthMustBeThree", "Airport Code Length Must Be Three");
        public static BaseError CheckOutDateMustBeSuperiourThenCheckIn = new BaseError("CheckOutDateMustBeSuperiourThenCheckIn", "Check Out Date Must Be Superiour Then Check In");
        public static BaseError CheckInDateMustBeGreaterThanToday = new BaseError("CheckInDateMustBeGreaterThanToday", "Check In Date Must Be Greater Than Today");
    }
}
