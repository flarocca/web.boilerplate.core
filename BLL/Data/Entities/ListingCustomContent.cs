using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class ListingCustomContent
    {
        [Column("idListingCustomContent")]
        [Key]
        public int IdListingCustomContent { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [Column("MLNumber")]
        [MaxLength(20)]
        public string Mlnumber { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
