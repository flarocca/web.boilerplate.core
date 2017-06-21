using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripTriggers
    {
        [Column("idDripTriggers")]
        [Key]
        public int IdDripTriggers { get; set; }
        [Column("idDripCampaign")]
        public int IdDripCampaign { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idDripCampaignTrigger")]
        public int IdDripCampaignTrigger { get; set; }
        public int TriggerLevel { get; set; }
    }
}
