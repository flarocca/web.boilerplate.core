using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Leads
    {
        public Leads()
        {
            ContextIoCluster = new HashSet<ContextIoCluster>();
            LeadAssignments = new HashSet<LeadAssignments>();
        }

        [Column("idLead")]
        [Key]
        public int IdLead { get; set; }
        [Required]
        [Column("idUser")]
        public Guid? IdUser { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [MaxLength(50)]
        public string AcceptKey { get; set; }
        public int? PreviousAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateActivity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateExpire { get; set; }
        [MaxLength(50)]
        public string UserPassword { get; set; }
        [MaxLength(50)]
        public string Telephone1 { get; set; }
        [MaxLength(50)]
        public string Telephone2 { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        public string Referral { get; set; }
        [MaxLength(500)]
        public string LandingPage { get; set; }
        [MaxLength(255)]
        public string LeadDetail { get; set; }
        [MaxLength(50)]
        public string LeadDetailType { get; set; }
        public short? Status { get; set; }
        [MaxLength(100)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(75)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }
        [Column(TypeName = "money")]
        public decimal? AveragePrice { get; set; }
        public int? ListingsViewed { get; set; }
        public byte EmailVerified { get; set; }
        [Column("FacebookID")]
        [MaxLength(20)]
        public string FacebookId { get; set; }
        [MaxLength(255)]
        public string FacebookPic { get; set; }
        public byte PhoneVerified { get; set; }
        [MaxLength(150)]
        public string PhoneCity { get; set; }
        [MaxLength(50)]
        public string PhoneState { get; set; }
        public bool? NeedsFinance { get; set; }
        [Column("idRule")]
        public int? IdRule { get; set; }
        [MaxLength(150)]
        public string FirstName { get; set; }
        [MaxLength(150)]
        public string LastName { get; set; }
        public bool UsrWelcomeMsg { get; set; }
        [Column("LinkedInID")]
        public int? LinkedInId { get; set; }
        [Column("LinkedInURL")]
        [MaxLength(200)]
        public string LinkedInUrl { get; set; }
        [Required]
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("importedIdLeads")]
        public int? ImportedIdLeads { get; set; }
        public int? LeadNumber { get; set; }
        public bool BadEmail { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }
        [MaxLength(100)]
        public string Area { get; set; }
        [MaxLength(100)]
        public string Company { get; set; }
        public byte LeadSource { get; set; }
        public bool Deleted { get; set; }
        [MaxLength(500)]
        public string LastPageViewed { get; set; }
        public byte LeadType { get; set; }
        public bool Sticky { get; set; }
        public byte AutoSavedSearches { get; set; }
        public byte AgentSavedSearches { get; set; }
        public byte UserSavedSearches { get; set; }
        [Column("ThirdPartyLeadID")]
        [MaxLength(25)]
        public string ThirdPartyLeadId { get; set; }
        [Column("ThirdPartyAgentID")]
        [MaxLength(25)]
        public string ThirdPartyAgentId { get; set; }
        public byte PhoneCallSuccesses { get; set; }
        public byte PhoneCallFails { get; set; }
        public byte TimeFrameType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeFrameEnd { get; set; }
        public bool InCommunication { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPhoneCall { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUserMessageDate { get; set; }
        public string LastUserMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastAgentActionDate { get; set; }
        public string LastAgentAction { get; set; }
        [Column(TypeName = "varchar(256)")]
        public string Phone1NumbersOnly { get; set; }
        [Column("FollowUpBossID")]
        public int? FollowUpBossId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FollowUpBossCreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FollowUpBossUpdatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FollowUpBossLastActivity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateTimeStamp { get; set; }
        public int AverageBedsViewed { get; set; }
        public int AverageBathsViewed { get; set; }
        [MaxLength(60)]
        public string AveragePropertyTypeViewed { get; set; }
        public bool Unfollowed { get; set; }
        public bool Unsubscribed { get; set; }
        public bool IsHidden { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastOnline { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastTouchDate { get; set; }
        public byte TotalTouches { get; set; }
        public byte LeadSphereType { get; set; }
        public byte TransactionType { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string LeadLookingForCity { get; set; }
        [Column(TypeName = "varchar(130)")]
        public string LeadLookingForHood { get; set; }
        public bool ReminderEmailSent { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? CreatedDateTimeOffset { get; set; }
        [Column("CaptureURL", TypeName = "varchar(300)")]
        public string CaptureUrl { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? ActivityDateTimeOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LastTouchOffset { get; set; }
        [Column("NoSMS")]
        public bool NoSms { get; set; }
        public bool UnsubscribedSent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastListingsViewedUpdate { get; set; }

        [InverseProperty("IdLeadNavigation")]
        public virtual ICollection<ContextIoCluster> ContextIoCluster { get; set; }
        [InverseProperty("IdLeadNavigation")]
        public virtual ICollection<LeadAssignments> LeadAssignments { get; set; }
    }
}
