using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class UserSavedProperties
    {
        [Column("idUserSavedProperties")]
        [Key]
        public Guid IdUserSavedProperties { get; set; }
        [Column("idUsers")]
        public Guid IdUsers { get; set; }
        [Column("MLNumber", TypeName = "varchar(50)")]
        public string Mlnumber { get; set; }
        public bool? IsTrash { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Saved { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Viewed { get; set; }
        public bool? SentByAgent { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? SavedOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? ViewedOffset { get; set; }
    }
}
