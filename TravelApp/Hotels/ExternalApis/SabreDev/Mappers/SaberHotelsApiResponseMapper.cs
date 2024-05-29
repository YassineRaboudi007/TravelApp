using TravelApp.Hotels.ExternalApis.SabreDev.ApiDtos;
using TravelApp.Hotels.HotelsQuery;

namespace TravelApp.Hotels.ExternalApis.SabreDev.Mappers
{
    public static class SaberHotelsApiResponseMapper
    {
        public static SimplifiedHotelInfo MapToSimplifiedResponse(SaberHotelsApiResponse response)
        {
            var simplifiedHotelInfo = new SimplifiedHotelInfo();

            simplifiedHotelInfo.Status = response.GetHotelAvailRS.ApplicationResults.status;

            if (response.GetHotelAvailRS.HotelAvailInfos.HotelAvailInfo != null && response.GetHotelAvailRS.HotelAvailInfos.HotelAvailInfo.Count > 0)
            {
                var hotelInfo = response.GetHotelAvailRS.HotelAvailInfos.HotelAvailInfo[0].HotelInfo;
                var rateInfo = response.GetHotelAvailRS.HotelAvailInfos.HotelAvailInfo[0].HotelRateInfo.RateRanges.RateRange[0];

                simplifiedHotelInfo.HotelName = hotelInfo.HotelName;
                simplifiedHotelInfo.HotelCode = hotelInfo.HotelCode;
                simplifiedHotelInfo.City = hotelInfo.LocationInfo.Address.CityName.value;
                simplifiedHotelInfo.State = hotelInfo.LocationInfo.Address.StateProv.value;
                simplifiedHotelInfo.Country = hotelInfo.LocationInfo.Address.CountryName.value;

                simplifiedHotelInfo.CurrencyCode = rateInfo.CurrencyCode;
                simplifiedHotelInfo.MinRate = double.Parse(rateInfo.MinRate);
                simplifiedHotelInfo.MaxRate = double.Parse(rateInfo.MaxRate);
            }

            return simplifiedHotelInfo;
        }
    }
}
