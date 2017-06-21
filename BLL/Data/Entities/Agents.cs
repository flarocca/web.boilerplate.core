using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Agents
    {
        public Agents()
        {
            AgentAvailability = new HashSet<AgentAvailability>();
            ContextIoCluster = new HashSet<ContextIoCluster>();
            LeadAssignments = new HashSet<LeadAssignments>();
        }

        [Column("idAgent")]
        [Key]
        public int IdAgent { get; set; }
        [Column("AgentUserID")]
        public Guid? AgentUserId { get; set; }
        [Column("MlsID")]
        [MaxLength(50)]
        public string MlsId { get; set; }
        public bool? LeadAdmin { get; set; }
        [MaxLength(50)]
        public string Cname { get; set; }
        public string CitySpecial { get; set; }
        public int? TotalReferrals { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastReferral { get; set; }
        public int? CosReferrals { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CosLast { get; set; }
        public int? TransferReferrals { get; set; }
        public int? CnameReferrals { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CnameLast { get; set; }
        public int? ManualSelectCount { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int? TxtCarrier { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        public int? Zip { get; set; }
        [MaxLength(3)]
        public string CellPhone1 { get; set; }
        [MaxLength(3)]
        public string CellPhone2 { get; set; }
        [MaxLength(4)]
        public string CellPhone3 { get; set; }
        [MaxLength(3)]
        public string OfficePhone1 { get; set; }
        [MaxLength(3)]
        public string OfficePhone2 { get; set; }
        [MaxLength(4)]
        public string OfficePhone3 { get; set; }
        [MaxLength(3)]
        public string TrackPhone1 { get; set; }
        [MaxLength(3)]
        public string TrackPhone2 { get; set; }
        [MaxLength(4)]
        public string TrackPhone3 { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        public byte Position { get; set; }
        [Column(TypeName = "ntext")]
        public string Blerb { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(200)]
        public string Picture { get; set; }
        public byte? Status { get; set; }
        public byte? Visible { get; set; }
        public byte? RentalLeads { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferOut1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferOut2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferOut3 { get; set; }
        public bool RentalAdmin { get; set; }
        public bool Deleted { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("importedIdAgent")]
        public int? ImportedIdAgent { get; set; }
        [Column("ContextIOToken")]
        [MaxLength(75)]
        public string ContextIotoken { get; set; }
        public string AgentSignature { get; set; }
        [MaxLength(200)]
        public string Logo { get; set; }
        public bool ShowFeaturedListings { get; set; }
        [MaxLength(200)]
        public string FaceBook { get; set; }
        [MaxLength(200)]
        public string LinkedIn { get; set; }
        [MaxLength(200)]
        public string Twitter { get; set; }
        [MaxLength(200)]
        public string ActiveRain { get; set; }
        [MaxLength(100)]
        public string Byline { get; set; }
        [MaxLength(500)]
        public string Certifications { get; set; }
        [MaxLength(500)]
        public string Awards { get; set; }
        public bool ShowAgentListings { get; set; }
        [MaxLength(200)]
        public string CustomBackgroundImage { get; set; }
        public string MoreInformation { get; set; }
        [MaxLength(50)]
        public string Suffix { get; set; }
        public bool Suspended { get; set; }
        [MaxLength(150)]
        public string GooglePlusAccount { get; set; }
        [MaxLength(30)]
        public string TwitterHandle { get; set; }
        [MaxLength(150)]
        public string YouTubeProfile { get; set; }
        [MaxLength(150)]
        public string PinterestProfile { get; set; }
        [MaxLength(75)]
        public string ShortBio { get; set; }
        public bool RentalsOnly { get; set; }
        public bool ApprovedBlogger { get; set; }
        public bool BetaTesting { get; set; }
        public bool AutoSearchOn { get; set; }
        [Column("ZillowAgentID")]
        [MaxLength(25)]
        public string ZillowAgentId { get; set; }
        public bool UseNewAdmin { get; set; }
        [Column("EditAgentSendNewLeadsSMS")]
        public bool EditAgentSendNewLeadsSms { get; set; }
        [MaxLength(8)]
        public string AgentTimeZone { get; set; }
        public bool AdminRightSideBarPosition { get; set; }
        [MaxLength(30)]
        public string ImportLeadsFrom { get; set; }
        public int? AgentNumber { get; set; }
        [Column("FollowUpBossAPIKey", TypeName = "varchar(100)")]
        public string FollowUpBossApikey { get; set; }
        public bool FollowUpBossEnabled { get; set; }
        public bool GetProActiveNotifications { get; set; }
        [Column("ProActNot_After14Days_On")]
        public bool ProActNotAfter14DaysOn { get; set; }
        [Column("ProActNot_After14Days_Email")]
        public bool ProActNotAfter14DaysEmail { get; set; }
        [Column("ProActNot_After14Days_TXT")]
        public bool ProActNotAfter14DaysTxt { get; set; }
        [Column("ProActNot_UncontactedLeadEmailClick_On")]
        public bool ProActNotUncontactedLeadEmailClickOn { get; set; }
        [Column("ProActNot_UncontactedLeadEmailClick_Email")]
        public bool ProActNotUncontactedLeadEmailClickEmail { get; set; }
        [Column("ProActNot_UncontactedLeadEmailClick_TXT")]
        public bool ProActNotUncontactedLeadEmailClickTxt { get; set; }
        [Column("ProActNot_RepeatedPropertyViews_On")]
        public bool ProActNotRepeatedPropertyViewsOn { get; set; }
        [Column("ProActNot_RepeatedPropertyViews_Email")]
        public bool ProActNotRepeatedPropertyViewsEmail { get; set; }
        [Column("ProActNot_RepeatedPropertyViews_TXT")]
        public bool ProActNotRepeatedPropertyViewsTxt { get; set; }
        [Column("ProActNot_SavedProperty_On")]
        public bool ProActNotSavedPropertyOn { get; set; }
        [Column("ProActNot_SavedProperty_Email")]
        public bool ProActNotSavedPropertyEmail { get; set; }
        [Column("ProActNot_SavedProperty_TXT")]
        public bool ProActNotSavedPropertyTxt { get; set; }
        [Column("ProActNot_SavedSearch_On")]
        public bool ProActNotSavedSearchOn { get; set; }
        [Column("ProActNot_SavedSearch_Email")]
        public bool ProActNotSavedSearchEmail { get; set; }
        [Column("ProActNot_SavedSearch_TXT")]
        public bool ProActNotSavedSearchTxt { get; set; }
        [Column("ProActNot_UserUnsub_On")]
        public bool ProActNotUserUnsubOn { get; set; }
        [Column("ProActNot_UserUnsub_Email")]
        public bool ProActNotUserUnsubEmail { get; set; }
        [Column("ProActNot_UserUnsub_TXT")]
        public bool ProActNotUserUnsubTxt { get; set; }
        [Column("ProActNot_Timeframe30DaysLeft_On")]
        public bool ProActNotTimeframe30DaysLeftOn { get; set; }
        [Column("ProActNot_Timeframe30DaysLeft_Email")]
        public bool ProActNotTimeframe30DaysLeftEmail { get; set; }
        [Column("ProActNot_Timeframe30DaysLeft_TXT")]
        public bool ProActNotTimeframe30DaysLeftTxt { get; set; }
        [Column("ProActNot_NewPartialLead_On")]
        public bool ProActNotNewPartialLeadOn { get; set; }
        [Column("ProActNot_NewPartialLead_Email")]
        public bool ProActNotNewPartialLeadEmail { get; set; }
        [Column("ProActNot_NewPartialLead_TXT")]
        public bool ProActNotNewPartialLeadTxt { get; set; }
        public bool SendImportedLeadsToQueue { get; set; }
        [Column("SecondaryAgentNotification_After14Days_On")]
        public bool SecondaryAgentNotificationAfter14DaysOn { get; set; }
        [Column("SecondaryAgentNotification_After14Days_Email")]
        public bool SecondaryAgentNotificationAfter14DaysEmail { get; set; }
        [Column("SecondaryAgentNotification_After14Days_TXT")]
        public bool SecondaryAgentNotificationAfter14DaysTxt { get; set; }
        [Column("SecondaryAgentNotification_UncontactedLeadEmailClick_On")]
        public bool SecondaryAgentNotificationUncontactedLeadEmailClickOn { get; set; }
        [Column("SecondaryAgentNotification_UncontactedLeadEmailClick_Email")]
        public bool SecondaryAgentNotificationUncontactedLeadEmailClickEmail { get; set; }
        [Column("SecondaryAgentNotification_UncontactedLeadEmailClick_TXT")]
        public bool SecondaryAgentNotificationUncontactedLeadEmailClickTxt { get; set; }
        [Column("SecondaryAgentNotification_RepeatedPropertyViews_On")]
        public bool SecondaryAgentNotificationRepeatedPropertyViewsOn { get; set; }
        [Column("SecondaryAgentNotification_RepeatedPropertyViews_Email")]
        public bool SecondaryAgentNotificationRepeatedPropertyViewsEmail { get; set; }
        [Column("SecondaryAgentNotification_RepeatedPropertyViews_TXT")]
        public bool SecondaryAgentNotificationRepeatedPropertyViewsTxt { get; set; }
        [Column("SecondaryAgentNotification_SavedProperty_On")]
        public bool SecondaryAgentNotificationSavedPropertyOn { get; set; }
        [Column("SecondaryAgentNotification_SavedProperty_Email")]
        public bool SecondaryAgentNotificationSavedPropertyEmail { get; set; }
        [Column("SecondaryAgentNotification_SavedProperty_TXT")]
        public bool SecondaryAgentNotificationSavedPropertyTxt { get; set; }
        [Column("SecondaryAgentNotification_SavedSearch_On")]
        public bool SecondaryAgentNotificationSavedSearchOn { get; set; }
        [Column("SecondaryAgentNotification_SavedSearch_Email")]
        public bool SecondaryAgentNotificationSavedSearchEmail { get; set; }
        [Column("SecondaryAgentNotification_SavedSearch_TXT")]
        public bool SecondaryAgentNotificationSavedSearchTxt { get; set; }
        [Column("SecondaryAgentNotification_UserUnsub_On")]
        public bool SecondaryAgentNotificationUserUnsubOn { get; set; }
        [Column("SecondaryAgentNotification_UserUnsub_Email")]
        public bool SecondaryAgentNotificationUserUnsubEmail { get; set; }
        [Column("SecondaryAgentNotification_UserUnsub_TXT")]
        public bool SecondaryAgentNotificationUserUnsubTxt { get; set; }
        [Column("SecondaryAgentNotification_Timeframe30DaysLeft_On")]
        public bool SecondaryAgentNotificationTimeframe30DaysLeftOn { get; set; }
        [Column("SecondaryAgentNotification_Timeframe30DaysLeft_Email")]
        public bool SecondaryAgentNotificationTimeframe30DaysLeftEmail { get; set; }
        [Column("SecondaryAgentNotification_Timeframe30DaysLeft_TXT")]
        public bool SecondaryAgentNotificationTimeframe30DaysLeftTxt { get; set; }
        [Column("SecondaryAgentNotification_NewPartialLead_On")]
        public bool SecondaryAgentNotificationNewPartialLeadOn { get; set; }
        [Column("SecondaryAgentNotification_NewPartialLead_Email")]
        public bool SecondaryAgentNotificationNewPartialLeadEmail { get; set; }
        [Column("SecondaryAgentNotification_NewPartialLead_TXT")]
        public bool SecondaryAgentNotificationNewPartialLeadTxt { get; set; }
        [Column("SecondaryAgentNotification_NewLeadAccept_On")]
        public bool SecondaryAgentNotificationNewLeadAcceptOn { get; set; }
        [Column("SecondaryAgentNotification_NewLeadAccept_Email")]
        public bool SecondaryAgentNotificationNewLeadAcceptEmail { get; set; }
        [Column("SecondaryAgentNotification_NewLeadAccept_TXT")]
        public bool SecondaryAgentNotificationNewLeadAcceptTxt { get; set; }
        [Column("SecondaryAgentNotification_NewLeadDetails_On")]
        public bool SecondaryAgentNotificationNewLeadDetailsOn { get; set; }
        [Column("SecondaryAgentNotification_NewLeadDetails_Email")]
        public bool SecondaryAgentNotificationNewLeadDetailsEmail { get; set; }
        [Column("SecondaryAgentNotification_NewLeadDetails_TXT")]
        public bool SecondaryAgentNotificationNewLeadDetailsTxt { get; set; }
        [Column("SecondaryAgentNotification_NewLeadAccept_FirstSecondaryGetsPrimary")]
        public bool SecondaryAgentNotificationNewLeadAcceptFirstSecondaryGetsPrimary { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string DefaultSecondaryAgents { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string AgentReviewPageText { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ZillowReviewsScreenName { get; set; }
        [Required]
        [MaxLength(160)]
        public string CustomAutoSavedSearchSubject { get; set; }
        [Required]
        public string CustomAutoSavedSearchBody { get; set; }
        [MaxLength(40)]
        public string PinterestDomainVerify { get; set; }
        [Column("GoogleOAuthRefreshToken", TypeName = "varchar(400)")]
        public string GoogleOauthRefreshToken { get; set; }
        [Column("GoogleOAuthTokenGoodUntil", TypeName = "datetime")]
        public DateTime? GoogleOauthTokenGoodUntil { get; set; }
        [Column("GoogleOAuthToken", TypeName = "varchar(400)")]
        public string GoogleOauthToken { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string CustomAgentFeaturedPropetiesQuery { get; set; }
        [Column("ProActNot_EnableDripAutoPause_On")]
        public bool ProActNotEnableDripAutoPauseOn { get; set; }
        [Column("ProActNot_EnableDripAutoPause_TXT")]
        public bool ProActNotEnableDripAutoPauseTxt { get; set; }
        [Column("ProActNot_EnableDripAutoPause_Email")]
        public bool ProActNotEnableDripAutoPauseEmail { get; set; }
        [Column("SecondaryAgentNotification_AcceptIncomingSMS")]
        public bool SecondaryAgentNotificationAcceptIncomingSms { get; set; }
        [Required]
        [Column("ThirdPartyNoAddressInitialSMSTemplate", TypeName = "varchar(160)")]
        public string ThirdPartyNoAddressInitialSmstemplate { get; set; }
        [Required]
        [Column("ThirdPartyAddressInitialSMSTemplate", TypeName = "varchar(160)")]
        public string ThirdPartyAddressInitialSmstemplate { get; set; }
        [Column("EditAgentSendThirdPartyLeadsInitialSMS")]
        public bool EditAgentSendThirdPartyLeadsInitialSms { get; set; }
        [Column("ProActNot_InboundSMS_On")]
        public bool ProActNotInboundSmsOn { get; set; }
        [Column("ProActNot_InboundSMS_Email")]
        public bool ProActNotInboundSmsEmail { get; set; }
        [Column("ProActNot_InboundSMS_TXT")]
        public bool ProActNotInboundSmsTxt { get; set; }
        [Column("SecondaryAgentNotification_AcceptIncomingSMS_TXT")]
        public bool SecondaryAgentNotificationAcceptIncomingSmsTxt { get; set; }
        [Column("SecondaryAgentNotification_AcceptIncomingSMS_Email")]
        public bool SecondaryAgentNotificationAcceptIncomingSmsEmail { get; set; }
        [Column("SecondaryAgentNotification_AcceptIncomingSMS_On")]
        public bool SecondaryAgentNotificationAcceptIncomingSmsOn { get; set; }
        public bool TextMessageConsent { get; set; }

        [InverseProperty("IdAgentNavigation")]
        public virtual ICollection<AgentAvailability> AgentAvailability { get; set; }
        [InverseProperty("IdAgentNavigation")]
        public virtual ICollection<ContextIoCluster> ContextIoCluster { get; set; }
        [InverseProperty("IdAgentNavigation")]
        public virtual ICollection<LeadAssignments> LeadAssignments { get; set; }
    }
}
