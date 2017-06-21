using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Rental
    {
        [Column("RentalID")]
        public int RentalId { get; set; }
        [Column("sysid")]
        [MaxLength(50)]
        public string Sysid { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        [MaxLength(50)]
        public string PropertyType { get; set; }
        [MaxLength(50)]
        public string InternetDisplay { get; set; }
        [MaxLength(50)]
        public string ImageCount { get; set; }
        [Column("ParcelID")]
        [MaxLength(50)]
        public string ParcelId { get; set; }
        [Column("ListAgentID")]
        [MaxLength(50)]
        public string ListAgentId { get; set; }
        [MaxLength(50)]
        public string CountyName { get; set; }
        [MaxLength(50)]
        public string Bedrooms { get; set; }
        [MaxLength(50)]
        public string ListAgentName { get; set; }
        [MaxLength(50)]
        public string ZipCode { get; set; }
        [MaxLength(50)]
        public string ZipPlus4 { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string StatusChangeDate { get; set; }
        [MaxLength(250)]
        public string VirtualTourLink { get; set; }
        [MaxLength(50)]
        public string LastImgTransDate { get; set; }
        [MaxLength(50)]
        public string ListDate { get; set; }
        [Column("ListOfficeID")]
        [MaxLength(50)]
        public string ListOfficeId { get; set; }
        [MaxLength(50)]
        public string ListPrice { get; set; }
        [Column("MLNumber")]
        [MaxLength(50)]
        public string Mlnumber { get; set; }
        [MaxLength(50)]
        public string StreetNumber { get; set; }
        [MaxLength(50)]
        public string LastTransDate { get; set; }
        [MaxLength(50)]
        public string TermsOfSale { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
        [MaxLength(50)]
        public string StreetName { get; set; }
        [MaxLength(50)]
        public string StreetDirectional { get; set; }
        [MaxLength(50)]
        public string ApplicationFee { get; set; }
        [MaxLength(50)]
        public string AprilRentType { get; set; }
        [MaxLength(50)]
        public string AugRentType { get; set; }
        [MaxLength(50)]
        public string AvailableDate { get; set; }
        [MaxLength(50)]
        public string Building { get; set; }
        [MaxLength(50)]
        public string Carport { get; set; }
        [MaxLength(50)]
        public string DamageDeposit { get; set; }
        [MaxLength(50)]
        public string DecRentType { get; set; }
        [MaxLength(50)]
        public string DevelopmentName { get; set; }
        [MaxLength(50)]
        public string Dock { get; set; }
        [MaxLength(50)]
        public string FurnishedAnnualRent { get; set; }
        [MaxLength(50)]
        public string FurnshdOffSeasnRent { get; set; }
        [MaxLength(50)]
        public string FurnishedSeasnRent { get; set; }
        [MaxLength(50)]
        public string FebRentType { get; set; }
        [Column("ForSaleYN")]
        [MaxLength(50)]
        public string ForSaleYn { get; set; }
        [MaxLength(50)]
        public string FrontExposure { get; set; }
        [MaxLength(50)]
        public string GoverningBody { get; set; }
        [MaxLength(50)]
        public string JanRentType { get; set; }
        [MaxLength(50)]
        public string JulyRentType { get; set; }
        [MaxLength(50)]
        public string JuneRentType { get; set; }
        [MaxLength(50)]
        public string MarchRentType { get; set; }
        [MaxLength(50)]
        public string MayRentType { get; set; }
        [MaxLength(50)]
        public string MinimunDaysLease { get; set; }
        [MaxLength(50)]
        public string DepositFirstMonth { get; set; }
        [MaxLength(50)]
        public string DepositLastMonth { get; set; }
        [MaxLength(50)]
        public string NovRentType { get; set; }
        [MaxLength(50)]
        public string OctRentType { get; set; }
        [MaxLength(50)]
        public string ParkingSpace { get; set; }
        [MaxLength(50)]
        public string PetDeposit { get; set; }
        [MaxLength(50)]
        public string PetsAllowed { get; set; }
        [Column("SaleMLSNumber")]
        [MaxLength(50)]
        public string SaleMlsnumber { get; set; }
        [MaxLength(50)]
        public string SepRentType { get; set; }
        [MaxLength(50)]
        public string TotalUnitsinBldg { get; set; }
        [MaxLength(50)]
        public string TotalUnitsinComplex { get; set; }
        [MaxLength(50)]
        public string UnfunshdAnnualRent { get; set; }
        [MaxLength(50)]
        public string UnfunshdOffseasnRent { get; set; }
        [MaxLength(50)]
        public string UnfunshdSeasnRent { get; set; }
        [MaxLength(50)]
        public string UnitFloor { get; set; }
        [MaxLength(50)]
        public string WaterFrontageinfeet { get; set; }
        [MaxLength(150)]
        public string BoatService { get; set; }
        [MaxLength(50)]
        public string Cooling { get; set; }
        [MaxLength(250)]
        public string Equipment { get; set; }
        [MaxLength(200)]
        public string ExteriorFeature { get; set; }
        [MaxLength(50)]
        public string Flooring { get; set; }
        [MaxLength(50)]
        public string Furnished { get; set; }
        [MaxLength(50)]
        public string Heating { get; set; }
        [MaxLength(200)]
        public string InteriorFeature { get; set; }
        [MaxLength(100)]
        public string Parking { get; set; }
        [MaxLength(50)]
        public string Membership { get; set; }
        [MaxLength(255)]
        public string Miscellaneous { get; set; }
        [MaxLength(150)]
        public string Restrictions { get; set; }
        [MaxLength(100)]
        public string Rooms { get; set; }
        [MaxLength(100)]
        public string Security { get; set; }
        [MaxLength(50)]
        public string Style { get; set; }
        [MaxLength(255)]
        public string SubdivisionInfo { get; set; }
        [MaxLength(50)]
        public string UnitDescription { get; set; }
        [MaxLength(50)]
        public string View { get; set; }
        [MaxLength(50)]
        public string UnitNumber { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(255)]
        public string Directions { get; set; }
        [MaxLength(50)]
        public string FullBaths { get; set; }
        [MaxLength(50)]
        public string HalfBaths { get; set; }
        [MaxLength(50)]
        public string ListAgentEmail { get; set; }
        [MaxLength(50)]
        public string ListAgentPhone { get; set; }
        [MaxLength(50)]
        public string ListOfficePhone { get; set; }
        [MaxLength(50)]
        public string ListOfficeName { get; set; }
        public string PublicRemarks { get; set; }
        public string Addenda { get; set; }
        [MaxLength(50)]
        public string TotalBaths { get; set; }
        [MaxLength(50)]
        public string SubdivisionName { get; set; }
        [MaxLength(50)]
        public string Zoning { get; set; }
        [MaxLength(50)]
        public string LivAreaSqFt { get; set; }
        [MaxLength(50)]
        public string SubType { get; set; }
        [Column("WaterfrontYN")]
        [MaxLength(50)]
        public string WaterfrontYn { get; set; }
        [MaxLength(50)]
        public string TotalFloors { get; set; }
        [MaxLength(50)]
        public string GeoArea { get; set; }
        [Column("PoolYN")]
        [MaxLength(50)]
        public string PoolYn { get; set; }
        [MaxLength(100)]
        public string WaterfrontDesc { get; set; }
        [MaxLength(50)]
        public string Garage { get; set; }
        [MaxLength(50)]
        public string AreaNumber { get; set; }
        [Column("RegionalIDMLX")]
        [MaxLength(50)]
        public string RegionalIdmlx { get; set; }
        [MaxLength(50)]
        public string MarketCode { get; set; }
        [MaxLength(50)]
        public string StreetSuffix { get; set; }
    }
}
