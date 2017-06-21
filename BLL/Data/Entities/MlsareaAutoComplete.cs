using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("MLSAreaAutoComplete")]
    public partial class MlsareaAutoComplete
    {
        [Column("idMLSAreaAutoComplete")]
        [Key]
        public int IdMlsareaAutoComplete { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [MaxLength(75)]
        public string GeoArea { get; set; }
        [Required]
        [MaxLength(5)]
        public string GeoAreaShort { get; set; }
    }
}
