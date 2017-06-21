using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class RetsClasses
    {
        [Column("idRetsClass")]
        [Key]
        public int IdRetsClass { get; set; }
        [Column("idRetsSetting")]
        public int IdRetsSetting { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [MaxLength(30)]
        public string ClassName { get; set; }
        public bool Import { get; set; }
        [MaxLength(100)]
        public string ClassDescription { get; set; }
        [MaxLength(750)]
        public string Query { get; set; }
        public byte ClassType { get; set; }
    }
}
