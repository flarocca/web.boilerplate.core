using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class HoodSeoInfo
    {
        [Column("idHoodSeoInfo")]
        [Key]
        public int IdHoodSeoInfo { get; set; }
        [Column(TypeName = "ntext")]
        public string SeoText { get; set; }
        [MaxLength(150)]
        public string HoodName { get; set; }
    }
}
