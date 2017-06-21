using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_PersonalizationPerUser")]
    public partial class PersonalizationPerUser
    {
        public Guid Id { get; set; }
        
		[Required]
        public Guid? PathId { get; set; }
        
		[Required]
        public Guid? UserId { get; set; }
        
		[Required]
        [Column(TypeName = "image")]
        [MaxLength(6000)]
        public byte[] PageSettings { get; set; }
        
		[Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

		[ForeignKey(nameof(PathId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Path.PersonalizationPerUser))]
        public virtual Path Path { get; set; }

		[ForeignKey(nameof(UserId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.User.PersonalizationPerUser))]
		public virtual User User { get; set; }
    }
}
