using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CitySubZipTEST")]
    public partial class CitySubZipTest
    {
        [Column("idCitySubZip")]
        public int IdCitySubZip { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(130)]
        public string SubdivisionName { get; set; }
        [MaxLength(12)]
        public string ZipCode { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [MaxLength(25)]
        public string CountyName { get; set; }
    }
}
