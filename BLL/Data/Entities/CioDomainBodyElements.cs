using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_Domain_Body_Elements", Schema = "CIO")]
    public partial class CioDomainBodyElements
    {
        [Column("idCIO_Domain_Body_Elements")]
        public int IdCioDomainBodyElements { get; set; }
        [Column("idCIO_DomainNames")]
        public int IdCioDomainNames { get; set; }
        [Required]
        [Column("CIO_Domain_Body_Elements")]
        [MaxLength(50)]
        public string CioDomainBodyElements1 { get; set; }
        [Required]
        [Column("CIO_Domain_Body_RegEx")]
        [MaxLength(150)]
        public string CioDomainBodyRegEx { get; set; }
        [Column("CIO_Leads_RequiredField")]
        public bool CioLeadsRequiredField { get; set; }
        public bool Active { get; set; }

        [ForeignKey("IdCioDomainNames")]
        [InverseProperty("CioDomainBodyElements")]
        public virtual CioDomainNames IdCioDomainNamesNavigation { get; set; }
    }
}
