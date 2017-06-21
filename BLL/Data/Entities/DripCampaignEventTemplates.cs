using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripCampaignEventTemplates
    {
        [Column("idDripCampaignEventTemplate")]
        [Key]
        public int IdDripCampaignEventTemplate { get; set; }
        [MaxLength(200)]
        public string EventSubject { get; set; }
        public string EmailJson { get; set; }
        public int EmailSent { get; set; }
        public int EmailOpen { get; set; }
        public int EmailClick { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public int EventType { get; set; }
        [MaxLength(200)]
        public string EventName { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public int ShareLevel { get; set; }
        public byte EmailFormat { get; set; }
    }
}
