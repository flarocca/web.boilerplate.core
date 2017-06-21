using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("StreetNameAutoComplete", Schema = "MLSDatacenter")]
    public partial class StreetNameAutoComplete
    {
        [Column("idStreetNameAutoComplete")]
        public int IdStreetNameAutoComplete { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetName { get; set; }
        [Required]
        [MaxLength(5)]
        public string First5 { get; set; }
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
    }
}
