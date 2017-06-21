using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("TorchxGL", Schema = "MLSDatacenter")]
    public partial class TorchxGl
    {
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [Column(TypeName = "binary(16)")]
        public byte[] CheckSum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
    }
}
