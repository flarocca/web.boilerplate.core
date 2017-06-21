using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_DomainNameSubjectTest", Schema = "CIO")]
    public partial class CioDomainNameSubjectTest
    {
        [Column("idCIO_DomainNameSubjectTest")]
        public int IdCioDomainNameSubjectTest { get; set; }
        [Column("idCIO_DomainNames")]
        public int IdCioDomainNames { get; set; }
        [Required]
        [Column("CIO_DomainNameSubjectTest")]
        [MaxLength(50)]
        public string CioDomainNameSubjectTest1 { get; set; }
        public bool Active { get; set; }

        [ForeignKey("IdCioDomainNames")]
        [InverseProperty("CioDomainNameSubjectTest")]
        public virtual CioDomainNames IdCioDomainNamesNavigation { get; set; }
    }
}
