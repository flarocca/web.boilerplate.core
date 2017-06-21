using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Contact
    {
        [Column("idContact")]
        [Key]
        public int IdContact { get; set; }
        [Column("idLead")]
        public int? IdLead { get; set; }
        [Column("idUser")]
        public Guid? IdUser { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        public int? ContactType { get; set; }
        public bool? FromClient { get; set; }
        public string Message { get; set; }
        [MaxLength(255)]
        public string Subject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        public bool IsPhone { get; set; }
        public byte PhoneType { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset CreatedOffset { get; set; }
    }
}
