using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadTags
    {
        [Column("idLeadTag")]
        [Key]
        public int IdLeadTag { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Required]
        [MaxLength(125)]
        public string Tag { get; set; }
    }
}
