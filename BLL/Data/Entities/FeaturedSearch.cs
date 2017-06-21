using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class FeaturedSearch
    {
        [Column("idFeaturedSearch")]
        [Key]
        public int IdFeaturedSearch { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public string QueryString { get; set; }
    }
}
