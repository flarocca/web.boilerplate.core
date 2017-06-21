using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class CitySeoInfo
    {
        [Column("idCitySeoInfo")]
        [Key]
        public int IdCitySeoInfo { get; set; }
        [Column(TypeName = "ntext")]
        public string SeoText { get; set; }
        [MaxLength(150)]
        public string CityName { get; set; }
    }
}
