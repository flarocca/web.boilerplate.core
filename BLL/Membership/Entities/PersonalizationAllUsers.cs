using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_PersonalizationAllUsers")]
    public partial class PersonalizationAllUsers
    {
        public Guid PathId { get; set; }
       
		[Required]
        [Column(TypeName = "image")]
        [MaxLength(6000)]
        public byte[] PageSettings { get; set; }
        
		[Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

		[ForeignKey(nameof(PathId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.Path.PersonalizationAllUsers))]
        public virtual Path Path { get; set; }
    }
}
