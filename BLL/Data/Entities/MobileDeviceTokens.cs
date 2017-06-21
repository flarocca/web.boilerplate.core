using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("MobileDeviceTokens", Schema = "Mobile")]
    public partial class MobileDeviceTokens
    {
        [Column("idMobileDeviceToken")]
        public int IdMobileDeviceToken { get; set; }
        [Column("idUser")]
        public Guid IdUser { get; set; }
        [Required]
        [Column("DeviceID")]
        [MaxLength(75)]
        public string DeviceId { get; set; }
        [Required]
        [MaxLength(40)]
        public string Token { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUsed { get; set; }
    }
}
