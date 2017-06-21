using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadDetails
    {
        [Column("idLeadDetail")]
        [Key]
        public int IdLeadDetail { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string SpouseTitle { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string SpouseFirstName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string SpouseLastName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string WorkAddress { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string WorkAddress2 { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string WorkCity { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string WorkState { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string WorkZip { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string WorkCountry { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Website { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string WorkTitle { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string WorkNotes { get; set; }
        public byte? ContactType { get; set; }
        public int? Birthday { get; set; }
        public int? WeddingAnniversary { get; set; }
        public bool? Male { get; set; }
        public int? SpouseBirthday { get; set; }
        public byte? MaritalStatus { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Religion { get; set; }
        public byte? Income { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string HouseholdMembers { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Notes { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string Referrals { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string WorkPhone { get; set; }
        public byte TimeFrame { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string WorkCompanyName { get; set; }
        [Column("SearchBehaviorJSON", TypeName = "varchar(max)")]
        public string SearchBehaviorJson { get; set; }
    }
}
