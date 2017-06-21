using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Scrollers
    {
        [Column("idScroller")]
        [Key]
        public int IdScroller { get; set; }
        [MaxLength(500)]
        public string ScrollerBackgrounds { get; set; }
        [MaxLength(500)]
        public string ScrollerHeadings { get; set; }
        [MaxLength(500)]
        public string ScrollerSubTitle { get; set; }
        [MaxLength(500)]
        public string ScrollerLinkUrl { get; set; }
        [MaxLength(500)]
        public string ScrollerLinkText { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string ScrollerGroupName { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [MaxLength(250)]
        public string ScrollerThumbnail { get; set; }
        public int OrderNum { get; set; }
        [MaxLength(200)]
        public string AttributionLink { get; set; }
        [MaxLength(200)]
        public string AttributionText { get; set; }
        public int ImageHeight { get; set; }
        public int ImageWidth { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string CustomContent { get; set; }
        public bool CustomSlider { get; set; }
    }
}
