using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Log
    {
        [Column("idLog")]
        [Key]
        public int IdLog { get; set; }
        [Column("UniqueID")]
        public Guid? UniqueId { get; set; }
        [Column("SessionID")]
        [MaxLength(100)]
        public string SessionId { get; set; }
        [MaxLength(50)]
        public string Event { get; set; }
        [MaxLength(400)]
        public string Detail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        public int? PageViewed { get; set; }
    }
}
