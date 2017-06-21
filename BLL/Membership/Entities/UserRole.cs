using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_UsersInRoles")]
    public partial class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

		[ForeignKey(nameof(RoleId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Role.UserRoles))]
        public virtual Role Role { get; set; }

		[ForeignKey(nameof(UserId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.User.UserRoles))]
		public virtual User User { get; set; }
    }
}
