using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DailySeoCache
    {
        [Column("idDailyCache")]
        [Key]
        public int IdDailyCache { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public byte PageType { get; set; }
        [Required]
        [Column("URLHash", TypeName = "binary(16)")]
        public byte[] Urlhash { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Required]
        [Column("DataJSON")]
        public string DataJson { get; set; }
    }
}
