using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("SettingsOLD")]
    public partial class SettingsOld
    {
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("URL", TypeName = "varchar(100)")]
        public string Url { get; set; }
        [Column("dbView", TypeName = "varchar(50)")]
        public string DbView { get; set; }
        public string BuyersText { get; set; }
        public string SellersText { get; set; }
        [MaxLength(150)]
        public string DefaultPageTitle { get; set; }
        [MaxLength(500)]
        public string MainFeaturedCity { get; set; }
        public string DefaultPageLeftBlerb { get; set; }
        public string DefaultPageRightBlerb { get; set; }
        public string FeaturedCityList { get; set; }
    }
}
