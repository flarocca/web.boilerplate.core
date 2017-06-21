using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("Listings")]
    public partial class Listings1
    {
        [Column("ListingID")]
        [Key]
        public int ListingId { get; set; }
        [Column("sysid", TypeName = "varchar(30)")]
        public string Sysid { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Addenda { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Address { get; set; }
        public int? Bedrooms { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string State { get; set; }
        [Column(TypeName = "varchar(475)")]
        public string Construction { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string CountyName { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string DevelopmentName { get; set; }
        [Column(TypeName = "varchar(650)")]
        public string Equipment { get; set; }
        [Column(TypeName = "varchar(425)")]
        public string ExteriorFeature { get; set; }
        [Column(TypeName = "varchar(220)")]
        public string Flooring { get; set; }
        public int? FullBaths { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Furnished { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string GarageNum { get; set; }
        [Column(TypeName = "varchar(60)")]
        public string GoverningBody { get; set; }
        public int? HalfBaths { get; set; }
        [Column("HOA", TypeName = "varchar(55)")]
        public string Hoa { get; set; }
        [Column("HOAAmount")]
        public int? Hoaamount { get; set; }
        [Column("HOAFeePer", TypeName = "varchar(30)")]
        public string HoafeePer { get; set; }
        public int? ImageCount { get; set; }
        [Column(TypeName = "varchar(850)")]
        public string InteriorFeature { get; set; }
        public double? ListPrice { get; set; }
        public int? LivAreaSqFt { get; set; }
        [Column(TypeName = "varchar(450)")]
        public string MaintenanceFeeIncludes { get; set; }
        [Column("MLNumber", TypeName = "varchar(30)")]
        public string Mlnumber { get; set; }
        public double? OriginalListPrice { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string Pool { get; set; }
        [Column(TypeName = "varchar(6000)")]
        public string PublicRemarks { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string Status { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SubType { get; set; }
        [Column(TypeName = "varchar(700)")]
        public string SubdivisionInfo { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string SubdivisionName { get; set; }
        public int? TaxAmount { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string TaxYear { get; set; }
        [Column(TypeName = "varchar(1200)")]
        public string Taxes { get; set; }
        [Column("TotalBldgSFIncl")]
        public int? TotalBldgSfincl { get; set; }
        [Column("Property_View", TypeName = "varchar(350)")]
        public string PropertyView { get; set; }
        [Column(TypeName = "varchar(600)")]
        public string VirtualTourLink { get; set; }
        [Column("WaterfrontYN", TypeName = "varchar(3)")]
        public string WaterfrontYn { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string WaterfrontDesc { get; set; }
        public int? YearBuilt { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string ZipCode { get; set; }
        [Column(TypeName = "varchar(130)")]
        public string Zoning { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string ListAgentName { get; set; }
        [Column(TypeName = "varchar(35)")]
        public string ListAgentPhone { get; set; }
        public bool? IsVisible { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string ListOfficeName { get; set; }
        public bool? IsNew { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastImgTransDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastImageDownload { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string PropertyType { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string InternetDisplay { get; set; }
        [Column("ParcelID", TypeName = "varchar(60)")]
        public string ParcelId { get; set; }
        [Column("ListAgentID", TypeName = "varchar(30)")]
        public string ListAgentId { get; set; }
        [Column("CDOM", TypeName = "varchar(5)")]
        public string Cdom { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string ZipPlus4 { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string ApplicationFee { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string BalconyLength { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string BalconyWidth { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string BuildingNum { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Bedrm2Length { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string Bedrm2Width { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Bedrm3Lendth { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Bedrm3Width { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string Bedrm4Length { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string Bedrm4Width { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Bedrm5Length { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string Bedrm5Width { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string CarportNum { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string DiningAreaLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string DiningAreaWidth { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string DenLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string DenWidth { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string DiningRmLength { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string DiningRmWidth { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string FamilyRmWidth { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string FamilyRmLength { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string MarketTime { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string FloridaRmLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string FloridaRmWidth { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string FrontExposure { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string GuestHouseSqft { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string KitchenLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string KitchenWidth { get; set; }
        [Column("ListOfficeID", TypeName = "varchar(30)")]
        public string ListOfficeId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string LivingRmLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string LivingRmWidth { get; set; }
        [Column(TypeName = "varchar(120)")]
        public string LotSize { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string LeaseTimesperYr { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string MasterBdrmLength { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string MasterBdrmWidth { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string MembershipEquity { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string MinimumDaysLease { get; set; }
        [Column(TypeName = "varchar(65)")]
        public string ModelName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PetsAllowed { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PoolLength { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string PoolWidth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTransDate { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string TermsOfSale { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string SpecialAssessment { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string TotalUnitsinBldg { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string TotalUnitsinComplex { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string UnitFloorNumber { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string WaterFrontageinfeet { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string BoatService { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Cooling { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Heating { get; set; }
        [Column(TypeName = "varchar(550)")]
        public string LotDescription { get; set; }
        [Column(TypeName = "varchar(160)")]
        public string Membership { get; set; }
        [Column(TypeName = "varchar(275)")]
        public string Parking { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string PrivatePoolDescription { get; set; }
        [Column(TypeName = "varchar(400)")]
        public string Restrictions { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Design { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string DiningArea { get; set; }
        [Column(TypeName = "varchar(90)")]
        public string GuestHouse { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string MobileHmFeatures { get; set; }
        [Column(TypeName = "varchar(210)")]
        public string MasterBdrmBath { get; set; }
        [Column(TypeName = "varchar(180)")]
        public string Roof { get; set; }
        [Column(TypeName = "varchar(650)")]
        public string Rooms { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string WindowTreatment { get; set; }
        [Column(TypeName = "varchar(350)")]
        public string Security { get; set; }
        [Column(TypeName = "varchar(330)")]
        public string SpecialInformation { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string UnitDescriptions { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Utilities { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string ListAgentEmail { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string ListOfficePhone { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string TotalFloors { get; set; }
        [Column(TypeName = "varchar(90)")]
        public string GeoArea { get; set; }
        [Column("RegionalIDMLX", TypeName = "varchar(1)")]
        public string RegionalIdmlx { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string MarketCode { get; set; }
        [Column("ShortSaleYN")]
        public bool? ShortSaleYn { get; set; }
        [Column("ForeclosureYN")]
        public bool? ForeclosureYn { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string AllowAddressDisplay { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string AllowValue { get; set; }
        [Column(TypeName = "varchar(3)")]
        public string AllowComments { get; set; }
        public int Indexed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [Column("MLSLogo", TypeName = "varchar(50)")]
        public string Mlslogo { get; set; }
        [Column("Lon_Rad")]
        public double? LonRad { get; set; }
        [Column("Lat_Rad")]
        public double? LatRad { get; set; }
        public bool? RentalListing { get; set; }
        [Column(TypeName = "varchar(1)")]
        public string OriginalCity { get; set; }
        [Column(TypeName = "varchar(60)")]
        public string OriginalSubdivisionName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastGeocodeAttempt { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("OldMLNumber")]
        [MaxLength(15)]
        public string OldMlnumber { get; set; }
        [Column("PropertyImageURL", TypeName = "varchar(100)")]
        public string PropertyImageUrl { get; set; }
        [Column("AWC_Remarks")]
        [MaxLength(30)]
        public string AwcRemarks { get; set; }
        public int? LivAreaSqFt2 { get; set; }
        public bool HasImage { get; set; }
        public long? LotSizeSqFt { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PlacesterApiKey { get; set; }
        [Column("idRetsSetting")]
        public int IdRetsSetting { get; set; }
        [Column(TypeName = "varchar(1600)")]
        public string Amenities { get; set; }
        [Column("School_Elem", TypeName = "varchar(160)")]
        public string SchoolElem { get; set; }
        [Column("School_Mid", TypeName = "varchar(160)")]
        public string SchoolMid { get; set; }
        [Column("School_High", TypeName = "varchar(160)")]
        public string SchoolHigh { get; set; }
        [Column("School_Elem_ID")]
        public int? SchoolElemId { get; set; }
        [Column("School_Mid_ID")]
        public int? SchoolMidId { get; set; }
        [Column("School_High_ID")]
        public int? SchoolHighId { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string AttachedType { get; set; }
        public bool FirePlace { get; set; }
        public bool HasBasement { get; set; }
        public bool HasPool { get; set; }
        public bool RetirementCommunity { get; set; }
        public int TotalGarageSpaces { get; set; }
        public bool GatedCommunity { get; set; }
        public bool NoHoa { get; set; }
        public bool WalkInCloset { get; set; }
        public bool IsWaterfront { get; set; }
        [Column("IsREO")]
        public bool IsReo { get; set; }
        public bool? PetsAllowedBit { get; set; }
        [Column("IsCBS")]
        public bool IsCbs { get; set; }
        public bool HasWoodFloors { get; set; }
        [Column("idRetsClass")]
        public int IdRetsClass { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string StreetName { get; set; }
        public int? RentalIncomeAnnual { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string LivAreaSqFtSource { get; set; }
        [Column(TypeName = "varchar(35)")]
        public string RentalCompany { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string RentalNumber { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string RentalName { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Directions { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Foundation { get; set; }
        [Column(TypeName = "varchar(400)")]
        public string Extras { get; set; }
        public int ImageDownloadAttempts { get; set; }
        public bool HasGuardedGate { get; set; }
        public int? ListPriceLow { get; set; }
        public int? ListPriceHigh { get; set; }
        public bool PartialImageDownload { get; set; }
        [Column("basement_details", TypeName = "varchar(150)")]
        public string BasementDetails { get; set; }
        [Column("contingent_change_date", TypeName = "datetime")]
        public DateTime? ContingentChangeDate { get; set; }
        [Column("exterior", TypeName = "varchar(310)")]
        public string Exterior { get; set; }
        [Column("fuel", TypeName = "varchar(75)")]
        public string Fuel { get; set; }
        [Column("kitchen_amenities", TypeName = "varchar(550)")]
        public string KitchenAmenities { get; set; }
        [Column("misc", TypeName = "varchar(175)")]
        public string Misc { get; set; }
        [Column("pers_prop_included", TypeName = "varchar(125)")]
        public string PersPropIncluded { get; set; }
        [Column("property_subject_to", TypeName = "varchar(175)")]
        public string PropertySubjectTo { get; set; }
        [Column("real_prop_excluded", TypeName = "varchar(175)")]
        public string RealPropExcluded { get; set; }
        [Column("sewer", TypeName = "varchar(125)")]
        public string Sewer { get; set; }
        [Column("road", TypeName = "varchar(100)")]
        public string Road { get; set; }
        [Column("type_of_contract", TypeName = "varchar(75)")]
        public string TypeOfContract { get; set; }
        [Column("Master_On_Main")]
        public bool MasterOnMain { get; set; }
        [Column("Listing_Agent_State_License_Number", TypeName = "varchar(50)")]
        public string ListingAgentStateLicenseNumber { get; set; }
        [Column("CoListing_Agent_Name", TypeName = "varchar(50)")]
        public string CoListingAgentName { get; set; }
        [Column("CoListing_Agent_Office_Name", TypeName = "varchar(75)")]
        public string CoListingAgentOfficeName { get; set; }
        [Column("CoListing_Agent_State_License_Number", TypeName = "varchar(50)")]
        public string CoListingAgentStateLicenseNumber { get; set; }
        public int ThreeQuarterBaths { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? DateTimeOffsetAdded { get; set; }
    }
}
