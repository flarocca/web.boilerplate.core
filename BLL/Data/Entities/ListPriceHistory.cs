using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class ListPriceHistory
    {
        [Column("idListPriceHistory")]
        [Key]
        public int IdListPriceHistory { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [Column("MLNumber", TypeName = "varchar(30)")]
        public string Mlnumber { get; set; }
        [Column(TypeName = "binary(16)")]
        public byte[] AddressCityStateHash { get; set; }
        public double? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PriceDate { get; set; }
        public byte EventType { get; set; }
    }
}
