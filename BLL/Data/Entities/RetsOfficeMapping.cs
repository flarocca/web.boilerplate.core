using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class RetsOfficeMapping
    {
        [Column("idRetsOfficeMapping")]
        [Key]
        public int IdRetsOfficeMapping { get; set; }
        [Column("idRetsSetting")]
        public int IdRetsSetting { get; set; }
        [Required]
        [Column("FieldMappingJSON")]
        public string FieldMappingJson { get; set; }
        [Required]
        [MaxLength(50)]
        public string ResourceName { get; set; }
        [Required]
        [MaxLength(50)]
        public string ClassName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Query { get; set; }
    }
}
