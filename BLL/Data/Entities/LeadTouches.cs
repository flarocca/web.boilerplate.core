using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadTouches
    {
        [Column("idLeadTouch")]
        [Key]
        public int IdLeadTouch { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idContact")]
        public int? IdContact { get; set; }
        [Column("idMandrill")]
        public int? IdMandrill { get; set; }
        [Column("idEmail")]
        public int? IdEmail { get; set; }
        public int TouchType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeadTouchDate { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Summary { get; set; }
        [Column("idSMSMessage")]
        public int? IdSmsmessage { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadTouchDateTimeOffset { get; set; }
    }
}
