using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("MLSAutoComplete")]
    public partial class MlsautoComplete
    {
        [Column("idMLSAutoComplete")]
        [Key]
        public int IdMlsautoComplete { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("MLNumber", TypeName = "varchar(20)")]
        public string Mlnumber { get; set; }
        [Required]
        [Column("MLNumberShort")]
        [MaxLength(5)]
        public string MlnumberShort { get; set; }
        [Column("ListingID")]
        public int? ListingId { get; set; }
    }
}
