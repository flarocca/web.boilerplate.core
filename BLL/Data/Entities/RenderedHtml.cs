using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("RenderedHTML")]
    public partial class RenderedHtml
    {
        [Column("idRenderedHTML")]
        [Key]
        public int IdRenderedHtml { get; set; }
        public int TimeStampRendered { get; set; }
        [Required]
        [Column("MLNumber")]
        [MaxLength(20)]
        public string Mlnumber { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [Column("RenderedHTML")]
        public string RenderedHtml1 { get; set; }
    }
}
