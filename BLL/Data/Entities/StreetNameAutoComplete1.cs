using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("StreetNameAutoComplete")]
    public partial class StreetNameAutoComplete1
    {
        [Column("idStreetNameAutoComplete")]
        [Key]
        public int IdStreetNameAutoComplete { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetName { get; set; }
        [Required]
        [MaxLength(5)]
        public string First5 { get; set; }
    }
}
