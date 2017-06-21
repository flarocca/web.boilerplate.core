using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class SchoolAutoSearch
    {
        [Required]
        [MaxLength(255)]
        public string SchoolName { get; set; }
        [Required]
        [MaxLength(5)]
        public string SchoolNameShort { get; set; }
        public int SchoolType { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
