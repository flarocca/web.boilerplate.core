using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("AgentAvailability", Schema = "SMS")]
    public partial class AgentAvailability
    {
        [Column("idAgentAvailability")]
        public int IdAgentAvailability { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column(TypeName = "varchar(6)")]
        public string TimeOffset { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]
        public string WeekDayName { get; set; }
        public TimeSpan? AvailStartTime { get; set; }
        public TimeSpan? AvailEndTime { get; set; }

        [ForeignKey("IdAgent")]
        [InverseProperty("AgentAvailability")]
        public virtual Agents IdAgentNavigation { get; set; }
    }
}
