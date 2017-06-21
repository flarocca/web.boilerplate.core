using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Agent
    {
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("Agent")]
        [MaxLength(50)]
        public string Agent1 { get; set; }
    }
}
