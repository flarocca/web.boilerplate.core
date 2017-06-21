using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMS_Cluster", Schema = "SMS")]
    public partial class SmsCluster
    {
        [Column("idSMS_Cluster")]
        public int IdSmsCluster { get; set; }
        [Column("idSMSMessageType")]
        public int IdSmsmessageType { get; set; }
        [Column("idSMSMessage")]
        public int IdSmsmessage { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idSMS_FLAG")]
        public int IdSmsFlag { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
    }
}
