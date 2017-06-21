using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Membership")]
    public partial class Membership
    {
        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
		public int PasswordFormat { get; set; }
		public bool IsApproved { get; set; }
		public bool IsLockedOut { get; set; }
		public int FailedPasswordAttemptCount { get; set; }
		public int FailedPasswordAnswerAttemptCount { get; set; }

		[Required]
        [MaxLength(128)]
        public string Password { get; set; }

        [Required]
        [MaxLength(128)]
        public string PasswordSalt { get; set; }

        [Column("MobilePIN")]
        [MaxLength(16)]
        public string MobilePin { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string LoweredEmail { get; set; }

        [MaxLength(256)]
        public string PasswordQuestion { get; set; }

        [MaxLength(128)]
        public string PasswordAnswer { get; set; }

		[Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LastLoginDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LastPasswordChangedDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LastLockoutDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FailedPasswordAttemptWindowStart { get; set; }
               
		[Column(TypeName = "datetime")]
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
        
		[Column(TypeName = "ntext")]
        [MaxLength(3000)]
        public string Comment { get; set; }

		[ForeignKey(nameof(ApplicationId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Application.Memberships))]
		public virtual Application Application { get; set; }

		[ForeignKey(nameof(UserId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.User.Memberships))]
		public virtual User User { get; set; }
    }
}
