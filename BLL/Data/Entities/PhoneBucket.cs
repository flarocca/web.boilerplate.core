using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class PhoneBucket
    {
        public PhoneBucket()
        {
            PhoneBucketNumbers = new HashSet<PhoneBucketNumbers>();
        }

        [Column("PhoneBucketID")]
        public int PhoneBucketId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PhoneBucketTitle { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public bool ManualBucket { get; set; }
        public bool Deleted { get; set; }
        public string QueryString { get; set; }

        [InverseProperty("PhoneBucket")]
        public virtual ICollection<PhoneBucketNumbers> PhoneBucketNumbers { get; set; }
    }
}
