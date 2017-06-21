using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ResultTable_work")]
    public partial class ResultTableWork
    {
        [Column("localID")]
        [Key]
        public int LocalId { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        public long? ListPrice { get; set; }
        public int? FullBaths { get; set; }
        public int? ThreeQuarterBaths { get; set; }
        public int? Bedrooms { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string SubdivisionName { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string Subtype { get; set; }
        [Column("DeletedIDSettings")]
        public int? DeletedIdsettings { get; set; }
        public long? DeletedPrice { get; set; }
        public int? DeletedBath { get; set; }
        public int? DeletedThreeBath { get; set; }
        public int? DeletedBedroom { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string DeletedCity { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string DeletedHood { get; set; }
        [Column(TypeName = "varchar(110)")]
        public string DeletedType { get; set; }
    }
}
