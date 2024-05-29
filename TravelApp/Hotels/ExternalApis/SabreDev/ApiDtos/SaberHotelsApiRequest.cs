using System;
using System.Collections.Generic;

namespace TravelApp.Hotels.ExternalApis.SabreDev.ApiDtos;

public class SaberHotelsApiRequest
{
    public GetHotelAvailRQ GetHotelAvailRQ { get; set; }

    public SaberHotelsApiRequest(string airportCode, DateTime checkIn, DateTime checkOut)
    {
        GetHotelAvailRQ = new GetHotelAvailRQ
        {
            SearchCriteria = new SearchCriteria
            {
                OffSet = 1,
                SortBy = "TotalRate",
                SortOrder = "DESC",
                PageSize = 20,
                TierLabels = false,
                GeoSearch = new GeoSearch
                {
                    GeoRef = new GeoRef
                    {
                        Radius = 50,
                        UOM = "MI",
                        RefPoint = new RefPoint
                        {
                            Value = airportCode,
                            ValueContext = "CODE",
                            RefPointType = "6"
                        }
                    }
                },
                RateInfoRef = new RateInfoRef
                {
                    ConvertedRateInfoOnly = false,
                    CurrencyCode = "USD",
                    BestOnly = "2",
                    PrepaidQualifier = "IncludePrepaid",
                    StayDateTimeRange = new StayDateTimeRange
                    {
                        StartDate = checkIn,
                        EndDate = checkOut
                    },
                    Rooms = new RequestRooms
                    {
                        Room = new List<RequestRoom>
                    {
                        new RequestRoom
                        {
                            Index = 1,
                            Adults = 1,
                            Children = 0
                        }
                    }
                    },
                    RateSource = "100,110,112,113"
                },
                HotelPref = new HotelPref
                {
                    SabreRating = new SabreRating
                    {
                        Min = 3,
                        Max = 5
                    }
                },
                ImageRef = new ImageRef
                {
                    Type = "MEDIUM",
                    LanguageCode = "EN"
                }
            }
        };
    }
}



public class GetHotelAvailRQ
{
    public SearchCriteria SearchCriteria { get; set; }
}

public class SearchCriteria
{
    public int OffSet { get; set; }
    public string SortBy { get; set; }
    public string SortOrder { get; set; }
    public int PageSize { get; set; }
    public bool TierLabels { get; set; }
    public bool RateDetailsInd { get; set; }
    public GeoSearch GeoSearch { get; set; }
    public RateInfoRef RateInfoRef { get; set; }
    public HotelPref HotelPref { get; set; }
    public ImageRef ImageRef { get; set; }
}

public class GeoSearch
{
    public GeoRef GeoRef { get; set; }
}

public class GeoRef
{
    public int Radius { get; set; }
    public string UOM { get; set; }
    public RefPoint RefPoint { get; set; }
}

public class RefPoint
{
    public string Value { get; set; }
    public string ValueContext { get; set; }
    public string RefPointType { get; set; }
}

public class RateInfoRef
{
    public string CurrencyCode { get; set; }
    public string BestOnly { get; set; }
    public string PrepaidQualifier { get; set; }
    public bool ConvertedRateInfoOnly { get; set; }
    public StayDateTimeRange StayDateTimeRange { get; set; }
    public string RateSource { get; set; }
    public RequestRooms Rooms { get; set; }
}

public class StayDateTimeRange
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class HotelPref
{
    public SabreRating SabreRating { get; set; }
}

public class SabreRating
{
    public double Min { get; set; }
    public double Max { get; set; }
}

public class ImageRef
{
    public string Type { get; set; }
    public string LanguageCode { get; set; }
}


public class RequestRooms
{
    public List<RequestRoom> Room { get; set; }
}

public class RequestRoom
{
    public int Index { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
}
