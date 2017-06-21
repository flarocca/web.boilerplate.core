using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class BlogInCats
    {
        [Column("idBlogInCats")]
        [Key]
        public int IdBlogInCats { get; set; }
        [Column("idBlog")]
        public int IdBlog { get; set; }
        [Column("idBlogCategories")]
        public int IdBlogCategories { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
    }
}
