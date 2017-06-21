using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class CountyAutoComplete
    {
        [Column("idCountyAutoComplete")]
        [Key]
        public int IdCountyAutoComplete { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [MaxLength(30)]
        public string County { get; set; }
        [MaxLength(5)]
        public string CountyShort { get; set; }
    }
}
