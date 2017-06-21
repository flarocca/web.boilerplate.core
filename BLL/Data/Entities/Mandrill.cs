using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Mandrill
    {
        [Column("idMandrill")]
        [Key]
        public int IdMandrill { get; set; }
        public bool? MandrillBounce { get; set; }
        public bool? MandrillClick { get; set; }
        public bool? MandrillOpen { get; set; }
        public bool? MandrillUnSub { get; set; }
        public bool? MandrillSend { get; set; }
        public bool? MandrillSpam { get; set; }
        public double? DateSent { get; set; }
        [Required]
        [MaxLength(150)]
        public string EmailSubject { get; set; }
        [Required]
        [Column("MessageID")]
        [MaxLength(60)]
        public string MessageId { get; set; }
        [Required]
        [MaxLength(75)]
        public string LeadEmail { get; set; }
        [Required]
        [MaxLength(100)]
        public string FromEmail { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public string SerializedEmail { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idDripCampaign")]
        public int? IdDripCampaign { get; set; }
        [Column("idDripCampaignEventTemplate")]
        public int? IdDripCampaignEventTemplate { get; set; }
        [Column("idMassEmail")]
        public int? IdMassEmail { get; set; }
        [Column("idAgentSentFrom")]
        public int? IdAgentSentFrom { get; set; }
        public bool UploadedToAzureBlob { get; set; }
    }
}
