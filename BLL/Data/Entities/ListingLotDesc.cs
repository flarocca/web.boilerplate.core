using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ListingLotDesc", Schema = "MLSDatacenter")]
    public partial class ListingLotDesc
    {
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [MaxLength(45)]
        public string LotDescription { get; set; }
    }
}
