using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_Test", Schema = "CIO")]
    public partial class CioTest
    {
        [Column("idCIO_Test")]
        public int IdCioTest { get; set; }
        [Required]
        [Column("CIO_Test_Name")]
        [MaxLength(50)]
        public string CioTestName { get; set; }
        [Required]
        [Column("CIO_Test_Description")]
        [MaxLength(300)]
        public string CioTestDescription { get; set; }
        [Required]
        [Column("CIO_Test")]
        public string CioTest1 { get; set; }
    }
}
