using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class TownCenter
    {
        [Column("idTownCenter")]
        [Key]
        public int IdTownCenter { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string Address { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string Thumbnail { get; set; }
        public int? Views { get; set; }
    }
}
