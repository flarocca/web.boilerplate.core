using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("event")]
    public partial class Event
    {
        [Column("idevent")]
        [Key]
        public int Idevent { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventEnd { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string Title { get; set; }
        [Column("URL", TypeName = "varchar(75)")]
        public string Url { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string Address { get; set; }
        [Column(TypeName = "money")]
        public decimal? Admission { get; set; }
        [Column("ImageURL", TypeName = "varchar(75)")]
        public string ImageUrl { get; set; }
        public int? Views { get; set; }
    }
}
