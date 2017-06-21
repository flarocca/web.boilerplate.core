using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("TaskMessage", Schema = "TASK")]
    public partial class TaskMessage
    {
        [Column("idTaskMessage")]
        public int IdTaskMessage { get; set; }
        [Required]
        [MaxLength(256)]
        public string TaskName { get; set; }
        [Required]
        [MaxLength(256)]
        public string ExecutingCode { get; set; }
        [Required]
        [Column("TaskMessage")]
        [MaxLength(256)]
        public string TaskMessage1 { get; set; }
        [Column("DateTimeInUTC", TypeName = "datetime")]
        public DateTime? DateTimeInUtc { get; set; }
    }
}
