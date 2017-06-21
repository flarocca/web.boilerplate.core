using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIOMessageType", Schema = "CIO")]
    public partial class CiomessageType
    {
        public CiomessageType()
        {
            ContextIoCluster = new HashSet<ContextIoCluster>();
        }

        [Column("idCIOMessageType")]
        public int IdCiomessageType { get; set; }
        [Required]
        [Column("CIOMessageType")]
        [MaxLength(50)]
        public string CiomessageType1 { get; set; }
        public bool Active { get; set; }

        [InverseProperty("IdCiomessageTypeNavigation")]
        public virtual ICollection<ContextIoCluster> ContextIoCluster { get; set; }
    }
}
