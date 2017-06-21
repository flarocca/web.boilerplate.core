using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class PhoneBucketNumbers
    {
        [Column("PhoneBucketNumbersID")]
        public int PhoneBucketNumbersId { get; set; }
        [Column("PhoneBucketID")]
        public int PhoneBucketId { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string PhoneNumber { get; set; }
        public bool? PotentialProblemWithNumber { get; set; }

        [ForeignKey("PhoneBucketId")]
        [InverseProperty("PhoneBucketNumbers")]
        public virtual PhoneBucket PhoneBucket { get; set; }
    }
}
