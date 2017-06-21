using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ListingRoofs", Schema = "MLSDatacenter")]
    public partial class ListingRoofs
    {
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [MaxLength(35)]
        public string Roof { get; set; }
    }
}
