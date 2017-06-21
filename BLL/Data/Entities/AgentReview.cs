using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class AgentReview
    {
        [Column("idAgentReview")]
        [Key]
        public int IdAgentReview { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column("agentScreenName")]
        [MaxLength(50)]
        public string AgentScreenName { get; set; }
        [Column("photoURL")]
        [MaxLength(100)]
        public string PhotoUrl { get; set; }
        [Column("followThroughRating")]
        public double? FollowThroughRating { get; set; }
        [Column("knowledgeableRating")]
        public double? KnowledgeableRating { get; set; }
        [Column("localKnowledgeRating")]
        public double? LocalKnowledgeRating { get; set; }
        [Column("processExpertiseRating")]
        public double? ProcessExpertiseRating { get; set; }
        [Column("responsivenessRating")]
        public double? ResponsivenessRating { get; set; }
        [Column("ProfileURL")]
        [MaxLength(100)]
        public string ProfileUrl { get; set; }
        [Column("modDate", TypeName = "datetime")]
        public DateTime? ModDate { get; set; }
    }
}
