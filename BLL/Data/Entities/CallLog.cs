using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CallLog", Schema = "ReadOnly")]
    public partial class CallLog
    {
        [Column("idCallLog")]
        [Key]
        public int IdCallLog { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("DateTimeUTC", TypeName = "datetime")]
        public DateTime DateTimeUtc { get; set; }
        public byte? ResultType { get; set; }
        [Column("idContact")]
        public int? IdContact { get; set; }
        [Column("idNotification")]
        public int? IdNotification { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? CreatedOffset { get; set; }
    }
}
