using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class NestedMenus
    {
        [Column("idNestedMenu")]
        [Key]
        public int IdNestedMenu { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idCustomPage")]
        public int? IdCustomPage { get; set; }
        [Column("idBlog")]
        public int? IdBlog { get; set; }
        [Column("URL")]
        [MaxLength(125)]
        public string Url { get; set; }
        [Required]
        [MaxLength(125)]
        public string Title { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
    }
}
