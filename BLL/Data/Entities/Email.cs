using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Email
    {
        [Column("idEmail")]
        [Key]
        public int IdEmail { get; set; }
        [Required]
        public string SerializedEmail { get; set; }
        [MaxLength(150)]
        public string EmailSubject { get; set; }
        [MaxLength(100)]
        public string LeadEmail { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [MaxLength(150)]
        public string FromEmail { get; set; }
        public double? DateReceived { get; set; }
        public bool EmailRead { get; set; }
        [MaxLength(250)]
        public string ToEmail { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
    }
}
