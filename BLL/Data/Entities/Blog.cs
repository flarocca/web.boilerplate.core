using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("blog")]
    public partial class Blog
    {
        [Column("idblog")]
        [Key]
        public int Idblog { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }
        [MaxLength(250)]
        public string BlogImage { get; set; }
        public int? ContentType { get; set; }
        [MaxLength(500)]
        public string BlogKeywords { get; set; }
        [MaxLength(600)]
        public string BlogDescription { get; set; }
        public int? ImageLayoutType { get; set; }
        public string EmbedCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        public int Views { get; set; }
        [MaxLength(150)]
        public string WebTitle { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public byte ShareLevel { get; set; }
    }
}
