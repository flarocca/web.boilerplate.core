using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class StateSeoInfo
    {
        [Column("idStateSeoInfo")]
        [Key]
        public int IdStateSeoInfo { get; set; }
        public string SeoText { get; set; }
        [MaxLength(150)]
        public string StateName { get; set; }
    }
}
