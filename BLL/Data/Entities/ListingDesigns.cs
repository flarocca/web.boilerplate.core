using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ListingDesigns", Schema = "MLSDatacenter")]
    public partial class ListingDesigns
    {
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [MaxLength(45)]
        public string Design { get; set; }
    }
}
