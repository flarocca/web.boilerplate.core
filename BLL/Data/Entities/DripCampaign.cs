using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripCampaign
    {
        [Column("idDripCampaign")]
        [Key]
        public int IdDripCampaign { get; set; }
        [Required]
        [MaxLength(75)]
        public string CampaignName { get; set; }
        public int TotalEmailSent { get; set; }
        public int TotalEmailClick { get; set; }
        public int TotalEmailOpen { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("idDripCampaignTrigger")]
        public int? IdDripCampaignTrigger { get; set; }
        public bool Active { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public int ShareLevel { get; set; }
        public int TotalEmailBounce { get; set; }
        [Column("idDripCampaignParent")]
        public int? IdDripCampaignParent { get; set; }
        [Column("idCompanyTrigger")]
        public int IdCompanyTrigger { get; set; }
        [Column("idTorchXTrigger")]
        public int IdTorchXtrigger { get; set; }
        public bool AutoPause { get; set; }
    }
}
