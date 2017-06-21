using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class MassEmail
    {
        [Column("idMassEmail")]
        [Key]
        public int IdMassEmail { get; set; }
        [Column("idDripCampaignEventTemplate")]
        public int IdDripCampaignEventTemplate { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public int SendTimeStamp { get; set; }
        public int EmailsSent { get; set; }
        public int EmailsClicked { get; set; }
        public int EmailsBounced { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public int EmailsOpened { get; set; }
        public string Filter { get; set; }
        [MaxLength(200)]
        public string AgentSelector { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public bool Deleted { get; set; }
        public bool Sent { get; set; }
        public int ActualSendTimeStamp { get; set; }
    }
}
