using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Users")]
    public partial class User
    {
        public User()
        {
            PersonalizationPerUser = new HashSet<PersonalizationPerUser>();
            UserRoles = new HashSet<UserRole>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
		public bool IsAnonymous { get; set; }

		[Required]
        [MaxLength(256)]
        public string UserName { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string LoweredUserName { get; set; }
        
		[MaxLength(16)]
        public string MobileAlias { get; set; }
        
		[Column(TypeName = "datetime")]
        public DateTime LastActivityDate { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Membership.User))]
		public virtual Membership Memberships { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.PersonalizationPerUser.User))]
		public virtual ICollection<PersonalizationPerUser> PersonalizationPerUser { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Profile.User))]
		public virtual Profile Profile { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.UserRole.User))]
		public virtual ICollection<UserRole> UserRoles { get; set; }
        
		[ForeignKey(nameof(ApplicationId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Application.Users))]
		public virtual Application Application { get; set; }
    }
}
