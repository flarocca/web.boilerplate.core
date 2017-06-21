using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class TargetAreas
    {
        [Column("idTargetArea")]
        [Key]
        public int IdTargetArea { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }
        [MaxLength(20)]
        public string CountyName { get; set; }
    }
}
