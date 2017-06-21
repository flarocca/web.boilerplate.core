using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CustomSEO")]
    public partial class CustomSeo
    {
        [Column("idCustomSEO")]
        [Key]
        public int IdCustomSeo { get; set; }
        [MaxLength(75)]
        public string Name { get; set; }
        public string SearchDetails { get; set; }
        [MaxLength(10)]
        public string PageType { get; set; }
        [MaxLength(150)]
        public string PageTitle { get; set; }
        [MaxLength(150)]
        public string PageKeywords { get; set; }
        [MaxLength(300)]
        public string PageDescription { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public bool ReplaceMatched { get; set; }
        public bool Active { get; set; }
        public int Views { get; set; }
        [MaxLength(100)]
        public string PreferredCity { get; set; }
        public string InvolvedCities { get; set; }
        [MaxLength(2)]
        public string PreferredState { get; set; }
        [MaxLength(20)]
        public string InvolvedStates { get; set; }
        [MaxLength(250)]
        public string Thumbnail { get; set; }
        public bool ShowDefaultText { get; set; }
        [MaxLength(75)]
        public string AboutTitle { get; set; }
        public string AboutText { get; set; }
        public bool ShowProperties { get; set; }
        [MaxLength(8)]
        public string CustomBgColor { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string HeaderText { get; set; }
    }
}
