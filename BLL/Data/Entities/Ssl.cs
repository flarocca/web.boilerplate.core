using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Ssl
    {
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("csr")]
        public string Csr { get; set; }
        [Column("sslEnabled")]
        public bool SslEnabled { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("term")]
        public int? Term { get; set; }
        [Column("approverEmailsJson")]
        [MaxLength(2000)]
        public string ApproverEmailsJson { get; set; }
        public string PrivateKey { get; set; }
        [Column("ca")]
        public string Ca { get; set; }
        [Column("idSSL")]
        public int IdSsl { get; set; }

        [ForeignKey("IdSettings")]
        [InverseProperty("Ssl")]
        public virtual Settings IdSettingsNavigation { get; set; }
    }
}
