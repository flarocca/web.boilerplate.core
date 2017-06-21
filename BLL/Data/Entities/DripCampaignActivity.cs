using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripCampaignActivity
    {
        [Column("idDripCampaignActivity")]
        [Key]
        public int IdDripCampaignActivity { get; set; }
        [Column("idMandrill")]
        public int IdMandrill { get; set; }
        public int SentTimeStamp { get; set; }
        [Required]
        [MaxLength(200)]
        public string Subject { get; set; }
        [Column("idDripCampaignEvent")]
        public int IdDripCampaignEvent { get; set; }
        [Column("idDripAssignment")]
        public int IdDripAssignment { get; set; }
        public bool NoticeRead { get; set; }
    }
}
