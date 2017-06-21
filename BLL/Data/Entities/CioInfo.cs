using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_Info", Schema = "CIO")]
    public partial class CioInfo
    {
        [Column("idCIO_Info")]
        public int IdCioInfo { get; set; }
        [Required]
        [Column("CIO_Info_Name")]
        [MaxLength(50)]
        public string CioInfoName { get; set; }
        [Required]
        [Column("CIO_Info_Description")]
        [MaxLength(300)]
        public string CioInfoDescription { get; set; }
        [Required]
        [Column("CIO_Info")]
        public string CioInfo1 { get; set; }
    }
}
