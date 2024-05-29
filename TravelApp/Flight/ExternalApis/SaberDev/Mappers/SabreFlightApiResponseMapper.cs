using System.Collections.Generic;
using System.Linq;
using TravelApp.Flight.ExternalApis.SaberDev.ApiDtos;
using TravelApp.Flight.FlightsQuery;

namespace TravelApp.Flight.ExternalApis.SaberDev.Mappers
{
    public static class FlightResponseMapper
    {
        public static List<FlightsQueryResponse> MapToFlightsQueryResponse(SabreFlightApiResponse apiResponse)
        {
            var result = new List<FlightsQueryResponse>();

            if (apiResponse?.PricedItineraries == null)
                return result;

            foreach (var itinerary in apiResponse.PricedItineraries)
            {
                if (itinerary.AirItinerary?.OriginDestinationOptions?.OriginDestinationOption == null)
                    continue;

                foreach (var option in itinerary.AirItinerary.OriginDestinationOptions.OriginDestinationOption)
                {
                    foreach (var segment in option.FlightSegment)
                    {
                        result.Add(new FlightsQueryResponse
                        {
                            AirlineCode = segment.MarketingAirline?.Code,
                            FlightNumber = segment.FlightNumber,
                            DepartureDateTime = segment.DepartureDateTime.ToString("yyyy-MM-ddTHH:mm:ss"),
                            ReturnDateTime = apiResponse.ReturnDateTime,
                            TotalAmount = itinerary.AirItineraryPricingInfo?.ItinTotalFare?.TotalFare?.Amount ?? 0,
                            Taxes = itinerary.AirItineraryPricingInfo?.ItinTotalFare?.Taxes?.Tax?.Sum(t => t.Amount) ?? 0,
                            BaseAmount = itinerary.AirItineraryPricingInfo?.ItinTotalFare?.BaseFare?.Amount ?? 0,
                            SeatsRemaining = CalculateSeatsRemaining(itinerary.AirItineraryPricingInfo?.FareInfos),
                        });
                    }
                }
            }

            return result;
        }

        private static int CalculateSeatsRemaining(FareInfos fareInfos)
        {
            return fareInfos?.FareInfo?.Select(fareInfo => fareInfo?.TPA_Extensions?.SeatsRemaining?.Number ?? 0).Sum() ?? 0;
        }
    }
}
