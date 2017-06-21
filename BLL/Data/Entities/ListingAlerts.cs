using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class ListingAlerts
    {
        [Column("idListingAlert")]
        [Key]
        public int IdListingAlert { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Required]
        [Column("MLS")]
        [MaxLength(250)]
        public string Mls { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SentTimestamp { get; set; }
    }
}
