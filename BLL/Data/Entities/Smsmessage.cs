using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMSMessage", Schema = "SMS")]
    public partial class Smsmessage
    {
        [Column("idSMSMessage")]
        public int IdSmsmessage { get; set; }
        [Required]
        [MaxLength(50)]
        public string ToPhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string FromPhone { get; set; }
        [Required]
        public string Body { get; set; }
        [MaxLength(50)]
        public string ToCountry { get; set; }
        [MaxLength(50)]
        public string ToState { get; set; }
        [Column("SMSMessageid")]
        [MaxLength(50)]
        public string Smsmessageid { get; set; }
        [MaxLength(50)]
        public string NumMedia { get; set; }
        [MaxLength(50)]
        public string ToCity { get; set; }
        [MaxLength(50)]
        public string FromZip { get; set; }
        [MaxLength(50)]
        public string SmsSid { get; set; }
        [MaxLength(50)]
        public string FromState { get; set; }
        [MaxLength(50)]
        public string SmsStatus { get; set; }
        [MaxLength(50)]
        public string FromCity { get; set; }
        [MaxLength(50)]
        public string FromCountry { get; set; }
        [MaxLength(50)]
        public string ToZip { get; set; }
        [MaxLength(50)]
        public string MessageSid { get; set; }
        [MaxLength(50)]
        public string AccountSid { get; set; }
        [MaxLength(50)]
        public string ApiVersion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeReceived { get; set; }
        [Column("idMassSMS")]
        public int? IdMassSms { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("idSMSMessageType")]
        public int? IdSmsmessageType { get; set; }
        [Column("idSMS_FLAG")]
        public int? IdSmsFlag { get; set; }
    }
}
