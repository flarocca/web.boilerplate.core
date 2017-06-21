using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_DomainNames", Schema = "CIO")]
    public partial class CioDomainNames
    {
        public CioDomainNames()
        {
            CioDomainBodyElements = new HashSet<CioDomainBodyElements>();
            CioDomainNameSubjectTest = new HashSet<CioDomainNameSubjectTest>();
        }

        [Column("idCIO_DomainNames")]
        public int IdCioDomainNames { get; set; }
        [Required]
        [Column("CIO_DomainNames")]
        [MaxLength(50)]
        public string CioDomainNames1 { get; set; }
        public bool Active { get; set; }

        [InverseProperty("IdCioDomainNamesNavigation")]
        public virtual ICollection<CioDomainBodyElements> CioDomainBodyElements { get; set; }
        [InverseProperty("IdCioDomainNamesNavigation")]
        public virtual ICollection<CioDomainNameSubjectTest> CioDomainNameSubjectTest { get; set; }
    }
}
