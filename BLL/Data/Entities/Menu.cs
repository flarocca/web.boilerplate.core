using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Menu
    {
        [Column("idMenu")]
        [Key]
        public int IdMenu { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [MaxLength(100)]
        public string PageName { get; set; }
        [Column("PageURL")]
        [MaxLength(300)]
        public string PageUrl { get; set; }
        public bool Active { get; set; }
        public int OrderNum { get; set; }
    }
}
