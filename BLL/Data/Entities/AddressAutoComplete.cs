using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class AddressAutoComplete
    {
        [Column("idAddressAutoComplete")]
        [Key]
        public int IdAddressAutoComplete { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("ListingID")]
        public int ListingId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [MaxLength(5)]
        public string First5 { get; set; }
    }
}
