using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("TempAreaStatistics", Schema = "Cache")]
    public partial class TempAreaStatistics
    {
        [Column("idTempAreaStatistics")]
        [Key]
        public int IdTempAreaStatistics { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string State { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string CountyName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string SubdivisionName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        [Column("IsMLSDC")]
        public bool? IsMlsdc { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string TopSubTypes { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string FirstPlaceSubType { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string SecondPlaceSubType { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string ThirdPlaceSubType { get; set; }
    }
}
