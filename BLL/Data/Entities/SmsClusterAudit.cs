using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMS_ClusterAudit", Schema = "SMS")]
    public partial class SmsClusterAudit
    {
        [Column("idSMS_ClusterAudit")]
        public int IdSmsClusterAudit { get; set; }
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
