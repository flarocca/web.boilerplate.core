using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ContextIO_Cluster", Schema = "CIO")]
    public partial class ContextIoCluster
    {
        [Column("idContextIO_Cluster")]
        public int IdContextIoCluster { get; set; }
        [Required]
        [Column("CIOAccountID")]
        [MaxLength(300)]
        public string CioaccountId { get; set; }
        [Required]
        [Column("ContextIO_MessageID")]
        [MaxLength(300)]
        public string ContextIoMessageId { get; set; }
        [Required]
        [MaxLength(300)]
        public string ToEmail { get; set; }
        [Column("idCIOMessageType")]
        public int IdCiomessageType { get; set; }
        [Column("idCIOMessage")]
        public int IdCiomessage { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idCIO_FLAG")]
        public int IdCioFlag { get; set; }

        [ForeignKey("IdAgent")]
        [InverseProperty("ContextIoCluster")]
        public virtual Agents IdAgentNavigation { get; set; }
        [ForeignKey("IdCioFlag")]
        [InverseProperty("ContextIoCluster")]
        public virtual CioFlag IdCioFlagNavigation { get; set; }
        [ForeignKey("IdCiomessage")]
        [InverseProperty("ContextIoCluster")]
        public virtual Ciomessage IdCiomessageNavigation { get; set; }
        [ForeignKey("IdCiomessageType")]
        [InverseProperty("ContextIoCluster")]
        public virtual CiomessageType IdCiomessageTypeNavigation { get; set; }
        [ForeignKey("IdLead")]
        [InverseProperty("ContextIoCluster")]
        public virtual Leads IdLeadNavigation { get; set; }
    }
}
