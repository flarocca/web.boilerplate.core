using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIOMessage", Schema = "CIO")]
    public partial class Ciomessage
    {
        public Ciomessage()
        {
            ContextIoCluster = new HashSet<ContextIoCluster>();
        }

        [Column("idCIOMessage")]
        public int IdCiomessage { get; set; }
        [Required]
        [Column("ContextIO_MessageID")]
        [MaxLength(300)]
        public string ContextIoMessageId { get; set; }
        [Required]
        [MaxLength(300)]
        public string ToEmail { get; set; }
        [Required]
        [MaxLength(300)]
        public string Domain { get; set; }
        [Required]
        [MaxLength(500)]
        public string Subject { get; set; }
        public string Body { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeReceived { get; set; }

        [InverseProperty("IdCiomessageNavigation")]
        public virtual ICollection<ContextIoCluster> ContextIoCluster { get; set; }
    }
}
