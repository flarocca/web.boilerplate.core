using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("Areastatistics", Schema = "Cache")]
    public partial class Areastatistics
    {
        [Column("idAreaStatistics")]
        public int IdAreaStatistics { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public string State { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string CountyName { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string SubdivisionName { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleAverageTimeOnMarket { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentAverageTimeOnMarket { get; set; }
        public double? SaleAveragePrice { get; set; }
        public double? RentAveragePrice { get; set; }
        public double? SaleMaxPrice { get; set; }
        public double? RentMaxPrice { get; set; }
        public double? SaleMinPrice { get; set; }
        public double? RentMinPrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleTotal { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentTotal { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string FirstPlaceSubTypeName { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleFirstPlace { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentFirstPlace { get; set; }
        public double? SaleAvgFirstPlacePrice { get; set; }
        public double? RentAvgFirstPlacePrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleAvgFirstPlaceTimeOnMarket { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentAvgFirstPlaceTimeOnMarket { get; set; }
        public double? SaleMaxFirstPlacePrice { get; set; }
        public double? RentMaxFirstPlacePrice { get; set; }
        public double? SaleMinFirstPlacePrice { get; set; }
        public double? RentMinFirstPlacePrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SecondPlaceSubTypeName { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleSecondPlace { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentSecondPlace { get; set; }
        public double? SaleAvgSecondPlacePrice { get; set; }
        public double? RentAvgSecondPlacePrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleAvgSecondPlaceTimeOnMarket { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentAvgSecondPlaceTimeOnMarket { get; set; }
        public double? SaleMaxSecondPlacePrice { get; set; }
        public double? RentMaxSecondPlacePrice { get; set; }
        public double? SaleMinSecondPlacePrice { get; set; }
        public double? RentMinSecondPlacePrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string ThirdPlaceSubTypeName { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleThirdPlace { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentThirdPlace { get; set; }
        public double? SaleAvgThirdPlacePrice { get; set; }
        public double? RentAvgThirdPlacePrice { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SaleAvgThirdPlaceTimeOnMarket { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string RentAvgThirdPlaceTimeOnMarket { get; set; }
        public double? SaleMaxThirdPlacePrice { get; set; }
        public double? RentMaxThirdPlacePrice { get; set; }
        public double? SaleMinThirdPlacePrice { get; set; }
        public double? RentMinThirdPlacePrice { get; set; }
        public long? ShortSales { get; set; }
        public double? AvgShortSalePrice { get; set; }
        public double? MaxShortSalePrice { get; set; }
        public double? MinShortSalePrice { get; set; }
        public bool? Foreclosures { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? ListPrice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Required]
        [Column("IsMLSDC")]
        public bool? IsMlsdc { get; set; }
        public int? AvgShortSaleTimeOnMarket { get; set; }
        public bool? NeedsReCalc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NeedsReCalcReqDate { get; set; }
    }
}
