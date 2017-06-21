using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMS_Flag", Schema = "SMS")]
    public partial class SmsFlag
    {
        [Column("idSMS_Flag")]
        public int IdSmsFlag { get; set; }
        [Required]
        [Column("SMS_Flag")]
        [MaxLength(50)]
        public string SmsFlag1 { get; set; }
        public bool Active { get; set; }
    }
}
