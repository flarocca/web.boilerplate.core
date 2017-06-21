using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadRotation
    {
        [Column("idLeadRotation")]
        [Key]
        public int IdLeadRotation { get; set; }
        [Required]
        [Column("COS")]
        [MaxLength(200)]
        public string Cos { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateLastLead { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
    }
}
