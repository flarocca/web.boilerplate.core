using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Applications")]
    public partial class Application
    {
		public Application()
        {
            Memberships = new HashSet<Membership>();
            Paths = new HashSet<Path>();
            Roles = new HashSet<Role>();
            Users = new HashSet<User>();
        }

		public Guid ApplicationId { get; set; }

		[MaxLength(256)]
		public string Description { get; set; }

        [Required]
        [MaxLength(256)]
        public string ApplicationName { get; set; }

        [Required]
        [MaxLength(256)]
        public string LoweredApplicationName { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.User.Application))]
		public virtual ICollection<User> Users { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Membership.Application))]
		public virtual ICollection<Membership> Memberships { get; set; }
        
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Path.Application))]
        public virtual ICollection<Path> Paths { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Role.Application))]
		public virtual ICollection<Role> Roles { get; set; }
    }
}
