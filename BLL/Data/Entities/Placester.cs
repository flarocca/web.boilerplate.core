using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Placester
    {
        [Column("idPlacester")]
        [Key]
        public int IdPlacester { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("FilterURLs")]
        public string FilterUrls { get; set; }
        [MaxLength(350)]
        public string ApiKeys { get; set; }
        [Column("MLSjson")]
        public string Mlsjson { get; set; }
    }
}
