using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class AgentDashViews
    {
        [Column("idAgentDashView")]
        [Key]
        public int IdAgentDashView { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        [Required]
        [Column("URL")]
        [MaxLength(250)]
        public string Url { get; set; }
    }
}
