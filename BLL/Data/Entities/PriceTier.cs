using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class PriceTier
    {
        [Column("idPriceTier")]
        [Key]
        public int IdPriceTier { get; set; }
        [Column("PriceTier")]
        public int PriceTier1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string PriceTierName { get; set; }
        [Column("maxNumUsers")]
        public int MaxNumUsers { get; set; }
    }
}
