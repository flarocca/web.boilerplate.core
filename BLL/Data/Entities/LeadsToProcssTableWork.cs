using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("LeadsToProcssTable_work")]
    public partial class LeadsToProcssTableWork
    {
        [Column("locaid")]
        [Key]
        public int Locaid { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idUser")]
        public Guid IdUser { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("dateactivity", TypeName = "datetime")]
        public DateTime Dateactivity { get; set; }
    }
}
