using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SMSMessageType", Schema = "SMS")]
    public partial class SmsmessageType
    {
        [Column("idSMSMessageType")]
        public int IdSmsmessageType { get; set; }
        [Required]
        [Column("SMSMessageType")]
        [MaxLength(50)]
        public string SmsmessageType1 { get; set; }
        public bool Active { get; set; }
    }
}
