using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Paths")]
    public partial class Path
    {
        public Path()
        {
            PersonalizationPerUser = new HashSet<PersonalizationPerUser>();
        }

        public Guid ApplicationId { get; set; }
        public Guid PathId { get; set; }
        
		[Required]
        [MaxLength(256)]
		[Column("Path")]
		public string Name { get; set; }
        
		[Required]
        [MaxLength(256)]
        public string LoweredPath { get; set; }

		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.PersonalizationAllUsers.Path))]
		public virtual PersonalizationAllUsers PersonalizationAllUsers { get; set; }
        
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.PersonalizationPerUser.Path))]
		public virtual ICollection<PersonalizationPerUser> PersonalizationPerUser { get; set; }
        
		[ForeignKey(nameof(ApplicationId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Application.Paths))]
		public virtual Application Application { get; set; }
    }
}
