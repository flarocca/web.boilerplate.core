using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Lead
    {
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("Lead")]
        [MaxLength(50)]
        public string Lead1 { get; set; }
    }
}
