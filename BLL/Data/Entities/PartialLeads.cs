using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class PartialLeads
    {
        [Column("idPartialLead")]
        [Key]
        public int IdPartialLead { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        public byte LeadType { get; set; }
        [MaxLength(110)]
        public string PropertyType { get; set; }
        public byte Condition { get; set; }
        public byte TimeFrame { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(75)]
        public string FirstName { get; set; }
        [MaxLength(75)]
        public string LastName { get; set; }
        [MaxLength(75)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public string Referral { get; set; }
        public bool Converted { get; set; }
        [Column("useragent")]
        [MaxLength(300)]
        public string Useragent { get; set; }
    }
}
