using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Notifications
    {
        [Column("idNotification")]
        [Key]
        public int IdNotification { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        public int NotificationTimeStamp { get; set; }
        public bool NoticeRead { get; set; }
        [Required]
        [MaxLength(255)]
        public string NotificationText { get; set; }
        public bool EmailSent { get; set; }
        public bool NoticeComplete { get; set; }
        public byte NotificationType { get; set; }
    }
}
