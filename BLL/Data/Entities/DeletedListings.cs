using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DeletedListings
    {
        [Column("ListingID")]
        [Key]
        public int ListingId { get; set; }
        [Column("sysid")]
        [MaxLength(100)]
        public string Sysid { get; set; }
        public string Addenda { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public int? Bedrooms { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        public string Construction { get; set; }
        [MaxLength(30)]
        public string CountyName { get; set; }
        [MaxLength(150)]
        public string DevelopmentName { get; set; }
        public string Equipment { get; set; }
        public string ExteriorFeature { get; set; }
        public string Flooring { get; set; }
        public int? FullBaths { get; set; }
        [MaxLength(124)]
        public string Furnished { get; set; }
        [MaxLength(150)]
        public string GarageNum { get; set; }
        [MaxLength(60)]
        public string GoverningBody { get; set; }
        public int? HalfBaths { get; set; }
        [Column("HOA")]
        [MaxLength(55)]
        public string Hoa { get; set; }
        [Column("HOAAmount")]
        public int? Hoaamount { get; set; }
        [Column("HOAFeePer")]
        [MaxLength(30)]
        public string HoafeePer { get; set; }
        public int? ImageCount { get; set; }
        public string InteriorFeature { get; set; }
        public double? ListPrice { get; set; }
        public int? LivAreaSqFt { get; set; }
        public string MaintenanceFeeIncludes { get; set; }
        [Column("MLNumber")]
        [MaxLength(30)]
        public string Mlnumber { get; set; }
        public double? OriginalListPrice { get; set; }
        [MaxLength(3)]
        public string Pool { get; set; }
        public string PublicRemarks { get; set; }
        [MaxLength(40)]
        public string Status { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SubType { get; set; }
        public string SubdivisionInfo { get; set; }
        [MaxLength(150)]
        public string SubdivisionName { get; set; }
        public int? TaxAmount { get; set; }
        [MaxLength(10)]
        public string TaxYear { get; set; }
        public string Taxes { get; set; }
        [Column("TotalBldgSFIncl")]
        public int? TotalBldgSfincl { get; set; }
        [Column("Property_View")]
        public string PropertyView { get; set; }
        [MaxLength(600)]
        public string VirtualTourLink { get; set; }
        [Column("WaterfrontYN")]
        [MaxLength(3)]
        public string WaterfrontYn { get; set; }
        public string WaterfrontDesc { get; set; }
        public int? YearBuilt { get; set; }
        [MaxLength(12)]
        public string ZipCode { get; set; }
        [Column(TypeName = "varchar(130)")]
        public string Zoning { get; set; }
        [MaxLength(70)]
        public string ListAgentName { get; set; }
        [MaxLength(35)]
        public string ListAgentPhone { get; set; }
        public bool? IsVisible { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        [MaxLength(128)]
        public string ListOfficeName { get; set; }
        public bool? IsNew { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastImgTransDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastImageDownload { get; set; }
        [MaxLength(75)]
        public string PropertyType { get; set; }
        [MaxLength(50)]
        public string InternetDisplay { get; set; }
        [Column("ParcelID")]
        [MaxLength(80)]
        public string ParcelId { get; set; }
        [Column("ListAgentID")]
        [MaxLength(50)]
        public string ListAgentId { get; set; }
        [Column("CDOM")]
        [MaxLength(50)]
        public string Cdom { get; set; }
        [MaxLength(50)]
        public string ZipPlus4 { get; set; }
        [MaxLength(50)]
        public string ApplicationFee { get; set; }
        [MaxLength(50)]
        public string BalconyLength { get; set; }
        [MaxLength(50)]
        public string BalconyWidth { get; set; }
        [MaxLength(50)]
        public string BuildingNum { get; set; }
        [MaxLength(50)]
        public string Bedrm2Length { get; set; }
        [MaxLength(50)]
        public string Bedrm2Width { get; set; }
        [MaxLength(50)]
        public string Bedrm3Lendth { get; set; }
        [MaxLength(50)]
        public string Bedrm3Width { get; set; }
        [MaxLength(50)]
        public string Bedrm4Length { get; set; }
        [MaxLength(50)]
        public string Bedrm4Width { get; set; }
        [MaxLength(50)]
        public string Bedrm5Length { get; set; }
        [MaxLength(50)]
        public string Bedrm5Width { get; set; }
        [MaxLength(75)]
        public string CarportNum { get; set; }
        [MaxLength(50)]
        public string DiningAreaLength { get; set; }
        [MaxLength(50)]
        public string DiningAreaWidth { get; set; }
        [MaxLength(50)]
        public string DenLength { get; set; }
        [MaxLength(50)]
        public string DenWidth { get; set; }
        [MaxLength(50)]
        public string DiningRmLength { get; set; }
        [MaxLength(50)]
        public string DiningRmWidth { get; set; }
        [MaxLength(50)]
        public string FamilyRmWidth { get; set; }
        [MaxLength(50)]
        public string FamilyRmLength { get; set; }
        [MaxLength(50)]
        public string MarketTime { get; set; }
        [MaxLength(50)]
        public string FloridaRmLength { get; set; }
        [MaxLength(50)]
        public string FloridaRmWidth { get; set; }
        [MaxLength(150)]
        public string FrontExposure { get; set; }
        [MaxLength(50)]
        public string GuestHouseSqft { get; set; }
        [MaxLength(50)]
        public string KitchenLength { get; set; }
        [MaxLength(50)]
        public string KitchenWidth { get; set; }
        [Column("ListOfficeID")]
        [MaxLength(50)]
        public string ListOfficeId { get; set; }
        [MaxLength(50)]
        public string LivingRmLength { get; set; }
        [MaxLength(50)]
        public string LivingRmWidth { get; set; }
        [MaxLength(150)]
        public string LotSize { get; set; }
        [MaxLength(200)]
        public string LeaseTimesperYr { get; set; }
        [MaxLength(50)]
        public string MasterBdrmLength { get; set; }
        [MaxLength(50)]
        public string MasterBdrmWidth { get; set; }
        [MaxLength(50)]
        public string MembershipEquity { get; set; }
        [MaxLength(200)]
        public string MinimumDaysLease { get; set; }
        [MaxLength(65)]
        public string ModelName { get; set; }
        [MaxLength(100)]
        public string PetsAllowed { get; set; }
        [MaxLength(200)]
        public string PoolLength { get; set; }
        [MaxLength(50)]
        public string PoolWidth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTransDate { get; set; }
        [MaxLength(255)]
        public string TermsOfSale { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string SpecialAssessment { get; set; }
        [MaxLength(50)]
        public string TotalUnitsinBldg { get; set; }
        [MaxLength(50)]
        public string TotalUnitsinComplex { get; set; }
        [MaxLength(50)]
        public string UnitFloorNumber { get; set; }
        [MaxLength(125)]
        public string WaterFrontageinfeet { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string BoatService { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Cooling { get; set; }
        [MaxLength(350)]
        public string Heating { get; set; }
        [MaxLength(550)]
        public string LotDescription { get; set; }
        [MaxLength(175)]
        public string Membership { get; set; }
        [MaxLength(280)]
        public string Parking { get; set; }
        [MaxLength(255)]
        public string PrivatePoolDescription { get; set; }
        [MaxLength(400)]
        public string Restrictions { get; set; }
        [MaxLength(400)]
        public string Design { get; set; }
        [MaxLength(300)]
        public string DiningArea { get; set; }
        [MaxLength(150)]
        public string GuestHouse { get; set; }
        [MaxLength(255)]
        public string MobileHmFeatures { get; set; }
        [Column(TypeName = "varchar(210)")]
        public string MasterBdrmBath { get; set; }
        [MaxLength(200)]
        public string Roof { get; set; }
        [MaxLength(650)]
        public string Rooms { get; set; }
        [MaxLength(255)]
        public string WindowTreatment { get; set; }
        [Column(TypeName = "varchar(350)")]
        public string Security { get; set; }
        [MaxLength(400)]
        public string SpecialInformation { get; set; }
        [MaxLength(200)]
        public string UnitDescriptions { get; set; }
        [MaxLength(300)]
        public string Utilities { get; set; }
        [MaxLength(100)]
        public string ListAgentEmail { get; set; }
        [MaxLength(50)]
        public string ListOfficePhone { get; set; }
        [MaxLength(50)]
        public string TotalFloors { get; set; }
        [MaxLength(90)]
        public string GeoArea { get; set; }
        [Column("RegionalIDMLX")]
        [MaxLength(50)]
        public string RegionalIdmlx { get; set; }
        [MaxLength(50)]
        public string MarketCode { get; set; }
        [Column("ShortSaleYN")]
        [MaxLength(50)]
        public string ShortSaleYn { get; set; }
        [Column("ForeclosureYN")]
        public bool? ForeclosureYn { get; set; }
        [MaxLength(50)]
        public string AllowAddressDisplay { get; set; }
        [MaxLength(50)]
        public string AllowValue { get; set; }
        [MaxLength(300)]
        public string AllowComments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        public int? Indexed { get; set; }
        [Column("MLSLogo")]
        [MaxLength(200)]
        public string Mlslogo { get; set; }
        public bool? RentalListing { get; set; }
        [Column("Lon_Rad")]
        public double? LonRad { get; set; }
        [Column("Lat_Rad")]
        public double? LatRad { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("PropertyImageURL")]
        [MaxLength(150)]
        public string PropertyImageUrl { get; set; }
        [Column("AWC_Remarks")]
        [MaxLength(30)]
        public string AwcRemarks { get; set; }
        public int? LivAreaSqFt2 { get; set; }
        public long? LotSizeSqFt { get; set; }
        [Column("idRetsSetting")]
        public int IdRetsSetting { get; set; }
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
        [MaxLength(100)]
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
        [MaxLength(70)]
        public string StreetName { get; set; }
        public int? RentalIncomeAnnual { get; set; }
        [MaxLength(75)]
        public string LivAreaSqFtSource { get; set; }
        [MaxLength(100)]
        public string RentalCompany { get; set; }
        [MaxLength(20)]
        public string RentalNumber { get; set; }
        [MaxLength(100)]
        public string RentalName { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Directions { get; set; }
        [MaxLength(150)]
        public string Foundation { get; set; }
        [MaxLength(400)]
        public string Extras { get; set; }
        public bool HasGuardedGate { get; set; }
        public int? ListPriceLow { get; set; }
        public int? ListPriceHigh { get; set; }
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
        [Column("misc", TypeName = "varchar(200)")]
        public string Misc { get; set; }
        [Column("pers_prop_included", TypeName = "varchar(200)")]
        public string PersPropIncluded { get; set; }
        [Column("property_subject_to", TypeName = "varchar(200)")]
        public string PropertySubjectTo { get; set; }
        [Column("real_prop_excluded", TypeName = "varchar(200)")]
        public string RealPropExcluded { get; set; }
        [Column("sewer", TypeName = "varchar(125)")]
        public string Sewer { get; set; }
        [Column("road", TypeName = "varchar(100)")]
        public string Road { get; set; }
        [Column("type_of_contract", TypeName = "varchar(100)")]
        public string TypeOfContract { get; set; }
        [Column("Listing_Agent_State_License_Number", TypeName = "varchar(50)")]
        public string ListingAgentStateLicenseNumber { get; set; }
        [Column("CoListing_Agent_Name", TypeName = "varchar(50)")]
        public string CoListingAgentName { get; set; }
        [Column("CoListing_Agent_Name2", TypeName = "varchar(50)")]
        public string CoListingAgentName2 { get; set; }
        [Column("CoListing_Agent_Office_Name", TypeName = "varchar(75)")]
        public string CoListingAgentOfficeName { get; set; }
        [Column("CoListing_Agent_State_License_Number", TypeName = "varchar(50)")]
        public string CoListingAgentStateLicenseNumber { get; set; }
        public int ThreeQuarterBaths { get; set; }
    }
}
