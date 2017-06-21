using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("TaskStatus", Schema = "TASK")]
    public partial class TaskStatus
    {
        [Column("idTaskStatus")]
        [Key]
        public int IdTaskStatus { get; set; }
        [Column("LastLeadPropViewsProcessed_DateTimeOffset")]
        public DateTimeOffset LastLeadPropViewsProcessedDateTimeOffset { get; set; }
    }
}
