using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripCampaignEvents
    {
        [Column("idDripCampaignEvents")]
        [Key]
        public int IdDripCampaignEvents { get; set; }
        [Column("idDripCampaign")]
        public int IdDripCampaign { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public int EventSendAfter { get; set; }
        public int EventSendAfterSeconds { get; set; }
        [Column("idDripCampaignEventTemplate")]
        public int IdDripCampaignEventTemplate { get; set; }
        public int EventSendAfterTime { get; set; }
    }
}
