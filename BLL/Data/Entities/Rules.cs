using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Rules
    {
        [Column("idRule")]
        [Key]
        public int IdRule { get; set; }
        public int OrderNum { get; set; }
        [MaxLength(30)]
        public string Type { get; set; }
        [MaxLength(20)]
        public string Value { get; set; }
        [MaxLength(10)]
        public string ToType { get; set; }
        [MaxLength(50)]
        public string ToIdentifier { get; set; }
        [MaxLength(5)]
        public string Comparison { get; set; }
        public bool? Active { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
    }
}
