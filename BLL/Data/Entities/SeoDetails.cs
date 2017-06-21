using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class SeoDetails
    {
        [Column("idSeoDetail")]
        [Key]
        public int IdSeoDetail { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        [MaxLength(200)]
        public string Neighborhood { get; set; }
        [MaxLength(200)]
        public string SeoString { get; set; }
        [MaxLength(150)]
        public string HeaderPic { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string NeighborhoodsFiltered { get; set; }
    }
}
