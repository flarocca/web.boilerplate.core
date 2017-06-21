using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadAssignments
    {
        [Column("idLeadAssignment")]
        public int IdLeadAssignment { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }

        [ForeignKey("IdAgent")]
        [InverseProperty("LeadAssignments")]
        public virtual Agents IdAgentNavigation { get; set; }
        [ForeignKey("IdLead")]
        [InverseProperty("LeadAssignments")]
        public virtual Leads IdLeadNavigation { get; set; }
    }
}
