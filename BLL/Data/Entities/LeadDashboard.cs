using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class LeadDashboard
    {
        [Column("idLeadDash")]
        [Key]
        public int IdLeadDash { get; set; }
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idPartialLead")]
        public int? IdPartialLead { get; set; }
        [Column("idAgent")]
        public int IdAgent { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public int? LeadNumber { get; set; }
        public bool LeadDeleted { get; set; }
        public bool LeadUnsubscribed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LeadLastOnline { get; set; }
        public bool LeadIsHidden { get; set; }
        public bool LeadInCommunication { get; set; }
        public bool LeadPinned { get; set; }
        [Column("UpdateDateUTC", TypeName = "datetime")]
        public DateTime UpdateDateUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(75)")]
        public string LeadFirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(75)")]
        public string LeadLastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LeadTelephone { get; set; }
        public double LeadTelephoneNumOnly { get; set; }
        public byte LeadTelephoneStatus { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LeadEmail { get; set; }
        public byte LeadEmailStatus { get; set; }
        public byte LeadSphereType { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string LeadLookingForCity { get; set; }
        [Column(TypeName = "varchar(130)")]
        public string LeadLookingForHood { get; set; }
        public byte LeadTransactionType { get; set; }
        public byte LeadSource { get; set; }
        [Required]
        [Column(TypeName = "varchar(max)")]
        public string LeadReferral { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string LeadLandingPage { get; set; }
        [Required]
        [Column("LeadFacebookID", TypeName = "varchar(20)")]
        public string LeadFacebookId { get; set; }
        [Column("LeadRegisteredUTC", TypeName = "datetime")]
        public DateTime LeadRegisteredUtc { get; set; }
        [Column("LeadLastActUTC", TypeName = "datetime")]
        public DateTime LeadLastActUtc { get; set; }
        public short LeadPropertiesViewed { get; set; }
        public int LeadAveragePrice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LeadLastTouchDate { get; set; }
        [Column("leadTotalTouches")]
        public byte LeadTotalTouches { get; set; }
        public int LeadAverageBeds { get; set; }
        public int LeadAverageBaths { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string LeadAveragePropertyType { get; set; }
        public byte LeadPropertiesSaved { get; set; }
        public int LeadSearchesConducted { get; set; }
        public byte LeadAutoSavedSearches { get; set; }
        public byte LeadAgentSavedSearches { get; set; }
        public byte LeadUserSavedSearches { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string LeadSavedSearchTypes { get; set; }
        public byte LeadSuccessfullCalls { get; set; }
        public byte LeadFailedCalls { get; set; }
        [Column("LeadTXTSent")]
        public int LeadTxtsent { get; set; }
        [Column("LeadTXTReceived")]
        public int LeadTxtreceived { get; set; }
        [Column("LeadLastCallTxtDateTimeUTC", TypeName = "datetime")]
        public DateTime? LeadLastCallTxtDateTimeUtc { get; set; }
        public byte LeadLastCallTxtType { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadLastCallTxtDetail { get; set; }
        public int LeadEmailsSent { get; set; }
        public int LeadEmailsOpened { get; set; }
        public int LeadEmailsClicked { get; set; }
        public int LeadEmailsReceived { get; set; }
        [Column("LeadLastEmailDateUTC", TypeName = "datetime")]
        public DateTime? LeadLastEmailDateUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadLastEmailDetail { get; set; }
        public bool LeadHasUnreadEmail { get; set; }
        [Column("LeadDripCampaignAssignedUTC", TypeName = "datetime")]
        public DateTime? LeadDripCampaignAssignedUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(75)")]
        public string LeadDripCampaignName { get; set; }
        public bool LeadDripCampaignActive { get; set; }
        [Column("LeadDripCampaignID")]
        public int LeadDripCampaignId { get; set; }
        public byte LeadStatus { get; set; }
        [Column("LeadTimeFrameEndUTC", TypeName = "datetime")]
        public DateTime? LeadTimeFrameEndUtc { get; set; }
        public byte LeadTimeFrameType { get; set; }
        [Required]
        [Column(TypeName = "varchar(35)")]
        public string LeadPrimaryAgentName { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadSecondaryAgentNames { get; set; }
        [Required]
        [Column("LeadSecondaryAgentIDs", TypeName = "varchar(300)")]
        public string LeadSecondaryAgentIds { get; set; }
        [Column("LeadAgentLastActivityUTC", TypeName = "datetime")]
        public DateTime? LeadAgentLastActivityUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadAgentLastActivityDetail { get; set; }
        [Column("LeadNextReminderDateUTC", TypeName = "datetime")]
        public DateTime? LeadNextReminderDateUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string LeadNextReminderDetail { get; set; }
        [Column("LeadNextReminderID")]
        public int LeadNextReminderId { get; set; }
        public byte LeadNextReminderType { get; set; }
        public byte LeadUpcomingReminderCount { get; set; }
        [Column("LeadProNoteUTC", TypeName = "datetime")]
        public DateTime? LeadProNoteUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadProNoteDetail { get; set; }
        public byte LeadNoteCount { get; set; }
        [Column("LeadNoteUTC", TypeName = "datetime")]
        public DateTime? LeadNoteUtc { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadNoteDetail { get; set; }
        [Column("idLeadStage")]
        public int IdLeadStage { get; set; }
        public byte LeadStageCurrentStep { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string LeadStageSteps { get; set; }
        [Required]
        [Column(TypeName = "varchar(750)")]
        public string LeadTags { get; set; }
        public int LeadProNoteCount { get; set; }
        public bool AveragesCalculated { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadLastActOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadLastTouchOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadRegisteredOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadProNoteOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadNoteOffset { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LeadLastCallTxtDateTimeOffset { get; set; }
        [Column("NoSMS")]
        public bool NoSms { get; set; }
        public bool UnsubscribedSent { get; set; }
    }
}
