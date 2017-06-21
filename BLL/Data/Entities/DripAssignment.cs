using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DripAssignment
    {
        [Column("idDripAssignment")]
        [Key]
        public int IdDripAssignment { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idDripCampaign")]
        public int IdDripCampaign { get; set; }
        public int TimeStampAssigned { get; set; }
        public int Active { get; set; }
    }
}
