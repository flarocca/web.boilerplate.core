using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class TwilioDialerLog
    {
        [Column("TwilioDialerLogID")]
        public int TwilioDialerLogId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CallName { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Required]
        [Column(TypeName = "varchar(11)")]
        public string FromPhone { get; set; }
        [Column("PhoneBucketID")]
        public int PhoneBucketId { get; set; }
        public int NumberOfPhonesDialed { get; set; }
        public int NumberOfSuccessConnections { get; set; }
        public int NumberOfAnsweringMachine { get; set; }
        public int NumberOfInvalid { get; set; }
        public int NumberOfUnsuccessful { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AgentStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgentEndDateTime { get; set; }
        public int TotalSecondsAgentInDialer { get; set; }
        public int TotalSecondsAgentOnCalls { get; set; }
    }
}
