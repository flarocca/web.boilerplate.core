using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class CountySeoInfo
    {
        [Column("idCountySeoInfo")]
        [Key]
        public int IdCountySeoInfo { get; set; }
        [Column(TypeName = "ntext")]
        public string SeoText { get; set; }
        [MaxLength(150)]
        public string CountyName { get; set; }
    }
}
