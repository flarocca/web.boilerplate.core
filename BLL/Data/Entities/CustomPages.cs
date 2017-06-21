using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class CustomPages
    {
        [Column("idCustomPage")]
        [Key]
        public int IdCustomPage { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        public byte Visibility { get; set; }
        [Required]
        [MaxLength(125)]
        public string PageTitle { get; set; }
        [Required]
        [MaxLength(125)]
        public string WebTitle { get; set; }
        [MaxLength(250)]
        public string PageDescription { get; set; }
        public string LeftFrame { get; set; }
        public string MainFrame { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public string ScriptTxt { get; set; }
        public bool FullScreen { get; set; }
    }
}
