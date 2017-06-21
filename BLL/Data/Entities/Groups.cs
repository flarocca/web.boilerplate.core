using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Groups
    {
        [Column("idGroup")]
        [Key]
        public int IdGroup { get; set; }
        [MaxLength(50)]
        public string GroupName { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastLead { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
    }
}
