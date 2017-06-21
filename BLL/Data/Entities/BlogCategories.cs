using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class BlogCategories
    {
        [Column("idBlogCategories")]
        [Key]
        public int IdBlogCategories { get; set; }
        [MaxLength(200)]
        public string CategoryName { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("lft")]
        public int Lft { get; set; }
        [Column("rgt")]
        public int Rgt { get; set; }
    }
}
