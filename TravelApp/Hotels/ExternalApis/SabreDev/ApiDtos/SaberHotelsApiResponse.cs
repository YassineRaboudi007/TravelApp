namespace TravelApp.Hotels.ExternalApis.SabreDev.ApiDtos;

public class SaberHotelsApiResponse
{
    public GetHotelAvailRS GetHotelAvailRS { get; set; }
}

public class AccessibleAmenities
{
    public List<Amenity> Amenity { get; set; }
}

public class AdditionalDetail
{
    public int Code { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public List<string> Text { get; set; }
}

public class AdditionalDetails
{
    public List<AdditionalDetail> AdditionalDetail { get; set; }
}

public class AdditionalInfo
{
    public List<Info> Info { get; set; }
}

public class Address
{
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public CityName CityName { get; set; }
    public StateProv StateProv { get; set; }
    public string PostalCode { get; set; }
    public CountryName CountryName { get; set; }
}

public class Amenities
{
    public List<Amenity> Amenity { get; set; }
}

public class Amenity
{
    public int Code { get; set; }
    public string Description { get; set; }
    public bool ComplimentaryInd { get; set; }
    public string value { get; set; }
}

public class AmountPercent
{
    public bool TaxInclusive { get; set; }
    public bool FeesInclusive { get; set; }
    public int NmbrOfNights { get; set; }
    public double Percent { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
}

public class ApplicationResults
{
    public string status { get; set; }
    public List<Success> Success { get; set; }
    public List<Error> Error { get; set; }
    public List<Warning> Warning { get; set; }
}

public class AvailableRatePlan
{
    public string RatePlanCode { get; set; }
    public string RatePlanType { get; set; }
    public string RatePlanTypeDescription { get; set; }
    public string ClientId { get; set; }
    public string RateSource { get; set; }
}

public class AvailableRatePlans
{
    public List<AvailableRatePlan> AvailableRatePlan { get; set; }
}

public class BedTypeClass
{
    public List<BedTypeClass> BedType { get; set; }
}

public class BedType2
{
    public int Code { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }
}

public class BedTypeOptions
{
    public List<BedTypeClass> BedTypes { get; set; }
}

public class CancelPenalties
{
    public List<CancelPenalty> CancelPenalty { get; set; }
}

public class CancelPenalty
{
    public bool Refundable { get; set; }
    public Deadline Deadline { get; set; }
    public AmountPercent AmountPercent { get; set; }
    public PenaltyDescription PenaltyDescription { get; set; }
}

public class Category
{
    public int CategoryCode { get; set; }
    public Description Description { get; set; }
}

public class CityName
{
    public string CityCode { get; set; }
    public string value { get; set; }
}

public class Commission
{
    public double Percent { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public string Type { get; set; }
    public CommissionDescription CommissionDescription { get; set; }
}

public class CommissionDescription
{
    public List<string> Text { get; set; }
}

public class Contact
{
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
}

public class ConvertedRateInfo
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string AmountBeforeTax { get; set; }
    public string AmountAfterTax { get; set; }
    public string MinSellingRate { get; set; }
    public string AverageNightlyRate { get; set; }
    public string AverageNightlyRateBeforeTax { get; set; }
    public string HighestNightlyRate { get; set; }
    public string ApproxTotalPrice { get; set; }
    public string CurrencyCode { get; set; }
    public bool AdditionalFeesInclusive { get; set; }
    public bool TaxInclusive { get; set; }
    public bool LocalFeesInclusive { get; set; }
    public bool IncidentalsInclusive { get; set; }
    public string RateSource { get; set; }
    public string RateKey { get; set; }
    public Commission Commission { get; set; }
    public Rates Rates { get; set; }
    public Taxes Taxes { get; set; }
    public Fees Fees { get; set; }
    public RoomExtras RoomExtras { get; set; }
    public CancelPenalties CancelPenalties { get; set; }
    public Guarantee Guarantee { get; set; }
    public AdditionalDetails AdditionalDetails { get; set; }
}

public class CountryName
{
    public string Code { get; set; }
    public string value { get; set; }
}

public class Deadline
{
    public string AbsoluteDeadline { get; set; }
    public string OffsetTimeUnit { get; set; }
    public int OffsetUnitMultiplier { get; set; }
    public string OffsetDropTime { get; set; }
}

public class DepositPolicies
{
    public List<DepositPolicy> DepositPolicy { get; set; }
}

public class DepositPolicy
{
    public Deadline Deadline { get; set; }
    public AmountPercent AmountPercent { get; set; }
}

public class Description
{
    public List<Text> Text { get; set; }
}

public class Error
{
    public string type { get; set; }
    public DateTime timeStamp { get; set; }
    public List<SystemSpecificResult> SystemSpecificResults { get; set; }
}

public class Fee
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
}

public class FeeDescription
{
    public List<string> Text { get; set; }
}

public class FeeGroup
{
    public int Code { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public FeeDescription FeeDescription { get; set; }
}

public class FeeGroups
{
    public List<FeeGroup> FeeGroup { get; set; }
}

public class Fees
{
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public List<Fee> Fee { get; set; }
    public FeeGroups FeeGroups { get; set; }
}

public class GetHotelAvailRS
{
    public ApplicationResults ApplicationResults { get; set; }
    public HotelAvailInfos HotelAvailInfos { get; set; }
}

public class Guarantee
{
    public string GuaranteeType { get; set; }
    public GuaranteesAccepted GuaranteesAccepted { get; set; }
    public DepositPolicies DepositPolicies { get; set; }
    public GuaranteeDescription GuaranteeDescription { get; set; }
}

public class GuaranteeAccepted
{
    public int GuaranteeTypeCode { get; set; }
    public string GuaranteeTypeDescription { get; set; }
    public PaymentCards PaymentCards { get; set; }
}

public class GuaranteeDescription
{
    public List<string> Text { get; set; }
}

public class GuaranteesAccepted
{
    public List<GuaranteeAccepted> GuaranteeAccepted { get; set; }
}

public class HostCommand
{
    public string LNIATA { get; set; }
}

public class HotelAvailInfo
{
    public HotelInfo HotelInfo { get; set; }
    public HotelRateInfo HotelRateInfo { get; set; }
    public HotelImageInfo HotelImageInfo { get; set; }
}

public class HotelAvailInfos
{
    public int OffSet { get; set; }
    public int MaxSearchResults { get; set; }
    public string ShopKey { get; set; }
    public double SearchLatitude { get; set; }
    public double SearchLongitude { get; set; }
    public List<HotelAvailInfo> HotelAvailInfo { get; set; }
    public List<TranslatedHotelAvailInfo> TranslatedHotelAvailInfo { get; set; }
}

public class HotelImageInfo
{
    public ImageItem ImageItem { get; set; }
}

public class HotelInfo
{
    public string HotelCode { get; set; }
    public string CodeContext { get; set; }
    public string SabreHotelCode { get; set; }
    public string HotelName { get; set; }
    public string ChainCode { get; set; }
    public string ChainName { get; set; }
    public string BrandCode { get; set; }
    public string BrandName { get; set; }
    public double Distance { get; set; }
    public string Direction { get; set; }
    public string UOM { get; set; }
    public string Logo { get; set; }
    public string SabreRating { get; set; }
    public bool CanReturnRequestedNegotiatedRate { get; set; }
    public int Ordinal { get; set; }
    public TierLabels TierLabels { get; set; }
    public LocationInfo LocationInfo { get; set; }
    public Amenities Amenities { get; set; }
    public SecurityFeatures SecurityFeatures { get; set; }
    public PropertyTypeInfo PropertyTypeInfo { get; set; }
    public PropertyQualityInfo PropertyQualityInfo { get; set; }
}

public class HotelRateInfo
{
    public RateRanges RateRanges { get; set; }
    public RateInfos RateInfos { get; set; }
    public Rooms Rooms { get; set; }
    public AvailableRatePlans AvailableRatePlans { get; set; }
    public RateUnavailability RateUnavailability { get; set; }
}

public class Image
{
    public string Url { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public string Type { get; set; }
}

public class ImageItem
{
    public string Id { get; set; }
    public int Ordinal { get; set; }
    public string LastModifedDate { get; set; }
    public string Format { get; set; }
    public Image Image { get; set; }
    public Category Category { get; set; }
    public AdditionalInfo AdditionalInfo { get; set; }
}

public class Info
{
    public string Type { get; set; }
    public Description Description { get; set; }
}

public class LocationInfo
{
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public Address Address { get; set; }
    public Neighborhoods Neighborhoods { get; set; }
    public Contact Contact { get; set; }
}

public class MealsIncluded
{
    public bool BreakFast { get; set; }
    public bool Lunch { get; set; }
    public bool Dinner { get; set; }
    public bool MealPlanIndicator { get; set; }
    public int MealPlanCode { get; set; }
    public string MealPlanDescription { get; set; }
    public int GuestCount { get; set; }
}

public class Message
{
    public string code { get; set; }
    public string value { get; set; }
}

public class Neighborhood
{
    public string Id { get; set; }
    public string value { get; set; }
}

public class Neighborhoods
{
    public List<Neighborhood> Neighborhood { get; set; }
}

public class Occupancy
{
    public int Min { get; set; }
    public int Max { get; set; }
}

public class PaymentCard
{
    public string CardCode { get; set; }
    public string value { get; set; }
}

public class PaymentCards
{
    public bool CVVRequired { get; set; }
    public List<PaymentCard> PaymentCard { get; set; }
}

public class PenaltyDescription
{
    public List<string> Text { get; set; }
}

public class PropertyQuality
{
    public int Code { get; set; }
    public string Description { get; set; }
}

public class PropertyQualityInfo
{
    public List<PropertyQuality> PropertyQuality { get; set; }
}

public class PropertyType
{
    public int Code { get; set; }
    public string Description { get; set; }
}

public class PropertyTypeInfo
{
    public List<PropertyType> PropertyType { get; set; }
}

public class Rate
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string AmountBeforeTax { get; set; }
    public string AmountAfterTax { get; set; }
    public string CurrencyCode { get; set; }
}

public class RateInfo
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string AmountBeforeTax { get; set; }
    public string AmountAfterTax { get; set; }
    public string MinSellingRate { get; set; }
    public string AverageNightlyRate { get; set; }
    public string AverageNightlyRateBeforeTax { get; set; }
    public string HighestNightlyRate { get; set; }
    public string ApproxTotalPrice { get; set; }
    public string CurrencyCode { get; set; }
    public bool AdditionalFeesInclusive { get; set; }
    public bool TaxInclusive { get; set; }
    public bool LocalFeesInclusive { get; set; }
    public bool IncidentalsInclusive { get; set; }
    public string RateSource { get; set; }
    public string RateKey { get; set; }
    public Commission Commission { get; set; }
    public Rates Rates { get; set; }
    public Taxes Taxes { get; set; }
    public Fees Fees { get; set; }
    public RoomExtras RoomExtras { get; set; }
    public CancelPenalties CancelPenalties { get; set; }
    public Guarantee Guarantee { get; set; }
    public AdditionalDetails AdditionalDetails { get; set; }
}

public class RateInfos
{
    public List<RateInfo> RateInfo { get; set; }
    public List<ConvertedRateInfo> ConvertedRateInfo { get; set; }
}

public class RatePlan
{
    public string RatePlanName { get; set; }
    public string RatePlanCode { get; set; }
    public string RatePlanType { get; set; }
    public string RatePlanTypeDescription { get; set; }
    public bool PrepaidIndicator { get; set; }
    public int AvailableQuantity { get; set; }
    public string LimitedAvailability { get; set; }
    public string RateSource { get; set; }
    public string RateKey { get; set; }
    public string ClientId { get; set; }
    public string ProductCode { get; set; }
    public string LoyaltyId { get; set; }
    public bool LoyaltyPoints { get; set; }
    public string LoyaltyProgramName { get; set; }
    public int Ordinal { get; set; }
    public RatePlanDescription RatePlanDescription { get; set; }
    public RatePlanInclusions RatePlanInclusions { get; set; }
    public MealsIncluded MealsIncluded { get; set; }
    public RateInfo RateInfo { get; set; }
    public ConvertedRateInfo ConvertedRateInfo { get; set; }
}

public class RatePlanDescription
{
    public List<string> Text { get; set; }
}

public class RatePlanInclusion
{
    public string Description { get; set; }
    public int Code { get; set; }
    public List<string> Text { get; set; }
}

public class RatePlanInclusions
{
    public List<RatePlanInclusion> RatePlanInclusion { get; set; }
}

public class RatePlans
{
    public List<RatePlan> RatePlan { get; set; }
}

public class RateRange
{
    public string MinRate { get; set; }
    public string MaxRate { get; set; }
    public string CurrencyCode { get; set; }
    public string ConvertedMinRate { get; set; }
    public string ConvertedMaxRate { get; set; }
    public string ConvertedCurrencyCode { get; set; }
    public string RateSource { get; set; }
}

public class RateRanges
{
    public List<RateRange> RateRange { get; set; }
}

public class Rates
{
    public List<Rate> Rate { get; set; }
}

public class RateSource
{
    public string Source { get; set; }
    public string DisplayMessage { get; set; }
    public string Reason { get; set; }
}

public class RateUnavailability
{
    public List<RateSource> RateSource { get; set; }
}

public class Room
{
    public int RoomIndex { get; set; }
    public string RoomType { get; set; }
    public int RoomTypeCode { get; set; }
    public string RoomCategory { get; set; }
    public string RoomID { get; set; }
    public int Floor { get; set; }
    public int RoomViewCode { get; set; }
    public string RoomViewDescription { get; set; }
    public bool NonSmoking { get; set; }
    public bool SharedRoomInd { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
    public BedTypeOptions BedTypeOptions { get; set; }
    public RoomDescription RoomDescription { get; set; }
    public AdditionalDetails AdditionalDetails { get; set; }
    public Amenities Amenities { get; set; }
    public AccessibleAmenities AccessibleAmenities { get; set; }
    public Occupancy Occupancy { get; set; }
    public RatePlans RatePlans { get; set; }
}

public class RoomDescription
{
    public string Name { get; set; }
    public List<string> Text { get; set; }
}

public class RoomExtra
{
    public int Code { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public List<string> Text { get; set; }
}

public class RoomExtras
{
    public List<RoomExtra> RoomExtra { get; set; }
}

public class Rooms
{
    public List<Room> Room { get; set; }
}

public class Root
{
    public GetHotelAvailRS GetHotelAvailRS { get; set; }
}

public class SecurityFeature
{
    public int Code { get; set; }
    public string Description { get; set; }
    public string value { get; set; }
}

public class SecurityFeatures
{
    public List<SecurityFeature> SecurityFeature { get; set; }
}

public class StateProv
{
    public string StateCode { get; set; }
    public string value { get; set; }
}

public class Success
{
    public string type { get; set; }
    public DateTime timeStamp { get; set; }
    public List<SystemSpecificResult> SystemSpecificResults { get; set; }
}

public class SystemSpecificResult
{
    public DateTime timeStamp { get; set; }
    public string reference { get; set; }
    public HostCommand HostCommand { get; set; }
    public List<Message> Message { get; set; }
}

public class Tax
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
}

public class TaxDescription
{
    public List<string> Text { get; set; }
}

public class Taxes
{
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public List<Tax> Tax { get; set; }
    public TaxGroups TaxGroups { get; set; }
}

public class TaxGroup
{
    public int Code { get; set; }
    public string Description { get; set; }
    public string Amount { get; set; }
    public string CurrencyCode { get; set; }
    public TaxDescription TaxDescription { get; set; }
}

public class TaxGroups
{
    public List<TaxGroup> TaxGroup { get; set; }
}

public class Text
{
    public string Language { get; set; }
    public string value { get; set; }
}

public class TierLabel
{
    public string Type { get; set; }
    public string Value { get; set; }
    public string ProgramId { get; set; }
}

public class TierLabels
{
    public List<TierLabel> TierLabel { get; set; }
}

public class TranslatedHotelAvailInfo
{
    public string LanguageCode { get; set; }
    public HotelInfo HotelInfo { get; set; }
    public HotelRateInfo HotelRateInfo { get; set; }
    public HotelImageInfo HotelImageInfo { get; set; }
}

public class Warning
{
    public string type { get; set; }
    public DateTime timeStamp { get; set; }
    public List<SystemSpecificResult> SystemSpecificResults { get; set; }
}
