using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("AndroidCloudMessagingRegistration", Schema = "Mobile")]
    public partial class AndroidCloudMessagingRegistration
    {
        [Column("idAndroidCloudMessagingRegistration")]
        public int IdAndroidCloudMessagingRegistration { get; set; }
        [Column("idUser")]
        public Guid IdUser { get; set; }
        [Required]
        [Column("DeviceID")]
        [MaxLength(75)]
        public string DeviceId { get; set; }
        [Column("Registration_ID")]
        [MaxLength(200)]
        public string RegistrationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUsed { get; set; }
    }
}
