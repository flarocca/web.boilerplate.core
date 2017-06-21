using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Roles")]
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string RoleName { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string LoweredRoleName { get; set; }
        
		[MaxLength(256)]
        public string Description { get; set; }

		[InverseProperty(nameof(Role))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
       
		[ForeignKey(nameof(ApplicationId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Application.Roles))]
		public virtual Application Application { get; set; }
    }
}
