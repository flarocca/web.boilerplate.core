using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ListingWaterfrontDescs", Schema = "MLSDatacenter")]
    public partial class ListingWaterfrontDescs1
    {
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string WaterfrontDesc { get; set; }
    }
}
