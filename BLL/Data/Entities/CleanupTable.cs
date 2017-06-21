using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CleanupTable", Schema = "RETS")]
    public partial class CleanupTable
    {
        [Column("idCleanupTable")]
        public int IdCleanupTable { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("idRetsSetting")]
        public int IdRetsSetting { get; set; }
        [Column("idRetsClass")]
        public int? IdRetsClass { get; set; }
        [Column("sysid", TypeName = "varchar(100)")]
        public string Sysid { get; set; }
    }
}
