using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_Profile")]
    public partial class Profile
    {
        public Guid UserId { get; set; }

		[Column(TypeName = "datetime")]
		public DateTime LastUpdatedDate { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        [MaxLength(6000)]
        public string PropertyNames { get; set; }
       
		[Required]
        [Column(TypeName = "ntext")]
        [MaxLength(6000)]
        public string PropertyValuesString { get; set; }
        
		[Required]
        [Column(TypeName = "image")]
        [MaxLength(6000)]
        public byte[] PropertyValuesBinary { get; set; }

		[ForeignKey(nameof(UserId))]
		[InverseProperty(nameof(Web.TORCHx.Core.BLL.Membership.User.Profile))]
        public virtual User User { get; set; }
    }
}
