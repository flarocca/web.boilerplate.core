using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripCampaignTrigger
    {
        [Column("idDripCampaignTrigger")]
        public int IdDripCampaignTrigger { get; set; }
        [MaxLength(100)]
        public string TriggerName { get; set; }
    }
}
