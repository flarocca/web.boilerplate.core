﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMSMessageAudit", Schema = "SMS")]
    public partial class SmsmessageAudit
    {
        [Column("idSMSMessageAudit")]
        public int IdSmsmessageAudit { get; set; }
        [Column("idSMSMessage")]
        public int IdSmsmessage { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
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
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeToAudit { get; set; }
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
        public bool? Processed { get; set; }
        public bool? IsPaid { get; set; }
        [Column("IdSMSPurchased")]
        public int? IdSmspurchased { get; set; }
        public int? TwillioResponseCode { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? DateReceivedOffset { get; set; }
    }
}
