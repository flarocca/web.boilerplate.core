using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_FLAG", Schema = "CIO")]
    public partial class CioFlag
    {
        public CioFlag()
        {
            ContextIoCluster = new HashSet<ContextIoCluster>();
        }

        [Column("idCIO_FLAG")]
        public int IdCioFlag { get; set; }
        [Required]
        [Column("CIO_Flag")]
        [MaxLength(50)]
        public string CioFlag1 { get; set; }
        public bool Active { get; set; }

        [InverseProperty("IdCioFlagNavigation")]
        public virtual ICollection<ContextIoCluster> ContextIoCluster { get; set; }
    }
}
