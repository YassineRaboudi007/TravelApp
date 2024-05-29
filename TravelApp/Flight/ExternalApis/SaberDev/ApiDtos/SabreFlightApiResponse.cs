namespace TravelApp.Flight.ExternalApis.SaberDev.ApiDtos
{

    using System;
    using System.Collections.Generic;

    public class SabreFlightApiResponse
    {
        public string ReturnDateTime { get; set; }
        public string DepartureDateTime { get; set; }
        public string DestinationLocation { get; set; }
        public string OriginLocation { get; set; }
        public List<PricedItinerary> PricedItineraries { get; set; }
        public Page Page { get; set; }
        public List<Link> Links { get; set; }
    }

    public class AirItinerary
    {
        public string DirectionInd { get; set; }
        public OriginDestinationOptions OriginDestinationOptions { get; set; }
    }

    public class AirItineraryPricingInfo
    {
        public TPAExtensions TPA_Extensions { get; set; }
        public ItinTotalFare ItinTotalFare { get; set; }
        public FareInfos FareInfos { get; set; }
        public PTCFareBreakdowns PTC_FareBreakdowns { get; set; }
    }

    public class ArrivalAirport
    {
        public string LocationCode { get; set; }
    }

    public class ArrivalTimeZone
    {
        public int GMTOffset { get; set; }
    }

    public class BaseFare
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public double Amount { get; set; }
    }

    public class CabinType
    {
        public string Cabin { get; set; }
    }

    public class DepartureAirport
    {
        public string LocationCode { get; set; }
    }

    public class DepartureTimeZone
    {
        public int GMTOffset { get; set; }
    }

    public class DisclosureAirline
    {
        public string Code { get; set; }
    }

    public class DivideInParty
    {
        public bool Indicator { get; set; }
    }

    public class Endorsements
    {
        public bool NonRefundableIndicator { get; set; }
    }

    public class Equipment
    {
        public string AirEquipType { get; set; }
    }

    public class EquivFare
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public double Amount { get; set; }
    }

    public class ETicket
    {
        public string Ind { get; set; }
    }

    public class FareBasisCode
    {
        public string BookingCode { get; set; }
        public string DepartureAirportCode { get; set; }
        public bool AvailabilityBreak { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string content { get; set; }
    }

    public class FareBasisCodes
    {
        public List<FareBasisCode> FareBasisCode { get; set; }
    }

    public class FareConstruction
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public double Amount { get; set; }
    }

    public class FareInfo
    {
        public string FareReference { get; set; }
        public TPAExtensions TPA_Extensions { get; set; }
    }

    public class FareInfos
    {
        public List<FareInfo> FareInfo { get; set; }
    }

    public class FlightSegment
    {
        public int StopQuantity { get; set; }
        public StopAirports StopAirports { get; set; }
        public DisclosureAirline DisclosureAirline { get; set; }
        public int ElapsedTime { get; set; }
        public string ResBookDesigCode { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int FlightNumber { get; set; }
        public string MarriageGrp { get; set; }
        public DepartureAirport DepartureAirport { get; set; }
        public ArrivalAirport ArrivalAirport { get; set; }
        public MarketingAirline MarketingAirline { get; set; }
        public ArrivalTimeZone ArrivalTimeZone { get; set; }
        public Equipment Equipment { get; set; }
        public OnTimePerformance OnTimePerformance { get; set; }
        public OperatingAirline OperatingAirline { get; set; }
        public DepartureTimeZone DepartureTimeZone { get; set; }
        public TPAExtensions TPA_Extensions { get; set; }
    }

    public class ItinTotalFare
    {
        public FareConstruction FareConstruction { get; set; }
        public TotalFare TotalFare { get; set; }
        public BaseFare BaseFare { get; set; }
        public EquivFare EquivFare { get; set; }
        public Taxes Taxes { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class MarketingAirline
    {
        public string Code { get; set; }
    }

    public class OnTimePerformance
    {
        public string Percentage { get; set; }
        public string Level { get; set; }
    }

    public class OperatingAirline
    {
        public int FlightNumber { get; set; }
        public string Code { get; set; }
        public string CompanyShortName { get; set; }
    }

    public class OriginDestinationOption
    {
        public int ElapsedTime { get; set; }
        public List<FlightSegment> FlightSegment { get; set; }
    }

    public class OriginDestinationOptions
    {
        public List<OriginDestinationOption> OriginDestinationOption { get; set; }
    }

    public class Page
    {
        public int Size { get; set; }
        public int TotalTags { get; set; }
        public int Offset { get; set; }
    }

    public class PassengerFare
    {
        public FareConstruction FareConstruction { get; set; }
        public TotalFare TotalFare { get; set; }
        public BaseFare BaseFare { get; set; }
        public EquivFare EquivFare { get; set; }
        public Taxes Taxes { get; set; }
    }

    public class PassengerTypeQuantity
    {
        public int Quantity { get; set; }
        public string Code { get; set; }
    }

    public class PricedItinerary
    {
        public int SequenceNumber { get; set; }
        public TicketingInfo TicketingInfo { get; set; }
        public TPAExtensions TPA_Extensions { get; set; }
        public AirItineraryPricingInfo AirItineraryPricingInfo { get; set; }
        public AirItinerary AirItinerary { get; set; }
    }

    public class PTCFareBreakdown
    {
        public PassengerTypeQuantity PassengerTypeQuantity { get; set; }
        public FareBasisCodes FareBasisCodes { get; set; }
        public PassengerFare PassengerFare { get; set; }
        public Endorsements Endorsements { get; set; }
    }

    public class PTCFareBreakdowns
    {
        public PTCFareBreakdown PTC_FareBreakdown { get; set; }
    }

    public class Root
    {
        public string ReturnDateTime { get; set; }
        public string DepartureDateTime { get; set; }
        public string DestinationLocation { get; set; }
        public string OriginLocation { get; set; }
        public List<PricedItinerary> PricedItineraries { get; set; }
        public Page Page { get; set; }
        public List<Link> Links { get; set; }
    }

    public class SeatsRemaining
    {
        public bool BelowMin { get; set; }
        public int Number { get; set; }
    }

    public class StopAirport
    {
        public string Equipment { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string LocationCode { get; set; }
        public int ElapsedTime { get; set; }
        public int Duration { get; set; }
        public int GMTOffset { get; set; }
    }

    public class StopAirports
    {
        public StopAirport StopAirport { get; set; }
    }

    public class Tax
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public string TaxCode { get; set; }
        public double Amount { get; set; }
    }

    public class Taxes
    {
        public List<Tax> Tax { get; set; }
        public TotalTax TotalTax { get; set; }
    }

    public class TicketingInfo
    {
        public string TicketType { get; set; }
        public string ValidInterline { get; set; }
    }

    public class TotalFare
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public double Amount { get; set; }
    }

    public class TotalTax
    {
        public string CurrencyCode { get; set; }
        public int DecimalPlaces { get; set; }
        public double Amount { get; set; }
    }

    public class TPAExtensions
    {
        public string TagID { get; set; }
        public ValidatingCarrier ValidatingCarrier { get; set; }
        public DivideInParty DivideInParty { get; set; }
        public CabinType Cabin { get; set; }
        public SeatsRemaining SeatsRemaining { get; set; }
        public ETicket eTicket { get; set; }
    }

    public class ValidatingCarrier
    {
        public string Code { get; set; }
    }
}
