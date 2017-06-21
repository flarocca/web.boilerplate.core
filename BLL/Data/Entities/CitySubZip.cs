using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class CitySubZip
    {
        [Column("idCitySubZip")]
        public int IdCitySubZip { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string SubdivisionName { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string ZipCode { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
    }
}
