using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class ListingStaging
    {
        [Column("idListingStaging")]
        [Key]
        public int IdListingStaging { get; set; }
        [Column("MLNumber")]
        [MaxLength(20)]
        public string Mlnumber { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("idRetsSettings")]
        public int? IdRetsSettings { get; set; }
    }
}
