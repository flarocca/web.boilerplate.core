﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class DatabaseContext : DbContext
    {
        public virtual DbSet<AddressAutoComplete> AddressAutoComplete { get; set; }
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<AgentAvailability> AgentAvailability { get; set; }
        public virtual DbSet<AgentDashViews> AgentDashViews { get; set; }
        public virtual DbSet<AgentReview> AgentReview { get; set; }
        public virtual DbSet<Agents> Agents { get; set; }
        public virtual DbSet<AndroidCloudMessagingRegistration> AndroidCloudMessagingRegistration { get; set; }
        public virtual DbSet<Areastatistics> Areastatistics { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<BlogCategories> BlogCategories { get; set; }
        public virtual DbSet<BlogInCats> BlogInCats { get; set; }
        public virtual DbSet<CallLog> CallLog { get; set; }
        public virtual DbSet<CioDomainBodyElements> CioDomainBodyElements { get; set; }
        public virtual DbSet<CioDomainNameSubjectTest> CioDomainNameSubjectTest { get; set; }
        public virtual DbSet<CioDomainNames> CioDomainNames { get; set; }
        public virtual DbSet<CioFlag> CioFlag { get; set; }
        public virtual DbSet<CioGmailPushInfo> CioGmailPushInfo { get; set; }
        public virtual DbSet<CioInfo> CioInfo { get; set; }
        public virtual DbSet<CioTest> CioTest { get; set; }
        public virtual DbSet<Ciomessage> Ciomessage { get; set; }
        public virtual DbSet<CiomessageType> CiomessageType { get; set; }
        public virtual DbSet<CitySeoInfo> CitySeoInfo { get; set; }
        public virtual DbSet<CitySubZip> CitySubZip { get; set; }
        public virtual DbSet<CitySubZipTest> CitySubZipTest { get; set; }
        public virtual DbSet<CleanupTable> CleanupTable { get; set; }
        public virtual DbSet<ClientAreas> ClientAreas { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContextIoCluster> ContextIoCluster { get; set; }
        public virtual DbSet<CountyAutoComplete> CountyAutoComplete { get; set; }
        public virtual DbSet<CountySeoInfo> CountySeoInfo { get; set; }
        public virtual DbSet<CustomPages> CustomPages { get; set; }
        public virtual DbSet<CustomSearchListings1> CustomSearchListings1 { get; set; }
        public virtual DbSet<CustomSeo> CustomSeo { get; set; }
        public virtual DbSet<DailySeoCache> DailySeoCache { get; set; }
        public virtual DbSet<DeletedListings> DeletedListings { get; set; }
        public virtual DbSet<DeletedSoldListings> DeletedSoldListings { get; set; }
        public virtual DbSet<DripAssignment> DripAssignment { get; set; }
        public virtual DbSet<DripCampaign> DripCampaign { get; set; }
        public virtual DbSet<DripCampaignActivity> DripCampaignActivity { get; set; }
        public virtual DbSet<DripCampaignEventTemplates> DripCampaignEventTemplates { get; set; }
        public virtual DbSet<DripCampaignEvents> DripCampaignEvents { get; set; }
        public virtual DbSet<DripCampaignTrigger> DripCampaignTrigger { get; set; }
        public virtual DbSet<DripTriggers> DripTriggers { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<FeaturedSearch> FeaturedSearch { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<HoodSeoInfo> HoodSeoInfo { get; set; }
        public virtual DbSet<ImportTemp> ImportTemp { get; set; }
        public virtual DbSet<Lead> Lead { get; set; }
        public virtual DbSet<LeadAssignments> LeadAssignments { get; set; }
        public virtual DbSet<LeadDashboard> LeadDashboard { get; set; }
        public virtual DbSet<LeadDetails> LeadDetails { get; set; }
        public virtual DbSet<LeadRotation> LeadRotation { get; set; }
        public virtual DbSet<LeadTags> LeadTags { get; set; }
        public virtual DbSet<LeadTouches> LeadTouches { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<LeadsToProcssTableWork> LeadsToProcssTableWork { get; set; }
        public virtual DbSet<ListPriceHistory> ListPriceHistory { get; set; }
        public virtual DbSet<ListingAlerts> ListingAlerts { get; set; }
        public virtual DbSet<ListingCustomContent> ListingCustomContent { get; set; }
        public virtual DbSet<ListingDesigns> ListingDesigns { get; set; }
        public virtual DbSet<ListingLotDesc> ListingLotDesc { get; set; }
        public virtual DbSet<ListingRoofs> ListingRoofs { get; set; }
        public virtual DbSet<ListingStaging> ListingStaging { get; set; }
        public virtual DbSet<ListingWaterfrontDescs1> ListingWaterfrontDescs1 { get; set; }
        public virtual DbSet<Listings> Listings { get; set; }
        public virtual DbSet<Listings1> Listings1 { get; set; }
        public virtual DbSet<ListingsSold> ListingsSold { get; set; }
        public virtual DbSet<ListingsSoldTemp> ListingsSoldTemp { get; set; }
        public virtual DbSet<ListingsTemp> ListingsTemp { get; set; }
        public virtual DbSet<ListingsTemp1> ListingsTemp1 { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogPartialLead> LogPartialLead { get; set; }
        public virtual DbSet<Mandrill> Mandrill { get; set; }
        public virtual DbSet<MapCustomArea> MapCustomArea { get; set; }
        public virtual DbSet<MapCustomAreaDetails> MapCustomAreaDetails { get; set; }
        public virtual DbSet<MassEmail> MassEmail { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MlsareaAutoComplete> MlsareaAutoComplete { get; set; }
        public virtual DbSet<MlsautoComplete> MlsautoComplete { get; set; }
        public virtual DbSet<MobileDeviceTokens> MobileDeviceTokens { get; set; }
        public virtual DbSet<NestedMenus> NestedMenus { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<PartialLeads> PartialLeads { get; set; }
        public virtual DbSet<PhoneBucket> PhoneBucket { get; set; }
        public virtual DbSet<PhoneBucketNumbers> PhoneBucketNumbers { get; set; }
        public virtual DbSet<Placester> Placester { get; set; }
        public virtual DbSet<PriceTier> PriceTier { get; set; }
        public virtual DbSet<RenderedHtml> RenderedHtml { get; set; }
        public virtual DbSet<Rental> Rental { get; set; }
        public virtual DbSet<ResultTableWork> ResultTableWork { get; set; }
        public virtual DbSet<RetsAgentMapping> RetsAgentMapping { get; set; }
        public virtual DbSet<RetsClasses> RetsClasses { get; set; }
        public virtual DbSet<RetsFields> RetsFields { get; set; }
        public virtual DbSet<RetsFieldsTemp> RetsFieldsTemp { get; set; }
        public virtual DbSet<RetsOfficeMapping> RetsOfficeMapping { get; set; }
        public virtual DbSet<RetsSettings> RetsSettings { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<SchoolAutoSearch> SchoolAutoSearch { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Scrollers> Scrollers { get; set; }
        public virtual DbSet<SeoDetails> SeoDetails { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SettingsOld> SettingsOld { get; set; }
        public virtual DbSet<SmsCluster> SmsCluster { get; set; }
        public virtual DbSet<SmsClusterAudit> SmsClusterAudit { get; set; }
        public virtual DbSet<SmsFlag> SmsFlag { get; set; }
        public virtual DbSet<Smsmessage> Smsmessage { get; set; }
        public virtual DbSet<SmsmessageAudit> SmsmessageAudit { get; set; }
        public virtual DbSet<SmsmessageType> SmsmessageType { get; set; }
        public virtual DbSet<Squeeze> Squeeze { get; set; }
        public virtual DbSet<Ssl> Ssl { get; set; }
        public virtual DbSet<StateSeoInfo> StateSeoInfo { get; set; }
        public virtual DbSet<StreetNameAutoComplete> StreetNameAutoComplete { get; set; }
        public virtual DbSet<StreetNameAutoComplete1> StreetNameAutoComplete1 { get; set; }
        public virtual DbSet<TargetAreas> TargetAreas { get; set; }
        public virtual DbSet<TaskMessage> TaskMessage { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<TempAreaStatistics> TempAreaStatistics { get; set; }
        public virtual DbSet<TorchxGl> TorchxGl { get; set; }
        public virtual DbSet<TownCenter> TownCenter { get; set; }
        public virtual DbSet<TwilioDialerLog> TwilioDialerLog { get; set; }
        public virtual DbSet<UserSavedProperties> UserSavedProperties { get; set; }
        public virtual DbSet<UserSavedSearches> UserSavedSearches { get; set; }
        public virtual DbSet<UserTracking> UserTracking { get; set; }

		// Unable to generate entity type for table 'dbo.CustomSearch_FieldType'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ListingWaterfrontDescs'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.CustomSearch_FieldValue'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.CustomSearch_Listings'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.SiteStatus'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TwilioDialerLogDetail'. Please see the warning messages.
		// Unable to generate entity type for table 'SMS.SMSTaskIndetifiers'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TwilioVerifiedNumbers'. Please see the warning messages.
		// Unable to generate entity type for table 'SMS.Incoming'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TempBrokerInfo'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TempAgentInfo'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.CustomSearch_FieldValue'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.CustomSearch_FieldType'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.ClientMLS'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.MLSCompliance'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.EmailTemplates'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.ListingClientLookUp'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.ListingClientAreas'. Please see the warning messages.
		// Unable to generate entity type for table 'MLSDatacenter.DeletedListings'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ListingClientLookUp'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.MlsFeedData'. Please see the warning messages.
		// Unable to generate entity type for table 'ReadOnly.LeadTimeline'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.Consent'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ListingDesigns'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ListingRoofs'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ListingLotDesc'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.CityStateList'. Please see the warning messages.
		// Unable to generate entity type for table 'CIO.Active_Agent_CIO'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.CustomSeoContent'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.APICompanyKeys'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.Review'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.LogFailedAttempt'. Please see the warning messages.
		// Unable to generate entity type for table 'SMS.SMSPurchases'. Please see the warning messages.
		// Unable to generate entity type for table 'SMS.MassSMS'. Please see the warning messages.

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressAutoComplete>(entity =>
            {
                entity.HasIndex(e => e.ListingId)
                    .HasName("RealTimeUpdates_ListingID");

                entity.HasIndex(e => new { e.IdSettings, e.ListingId })
                    .HasName("idSettings_ListingID_Index");

                entity.HasIndex(e => new { e.IdAddressAutoComplete, e.First5, e.IdSettings })
                    .HasName("idSettingsIndex");

                entity.HasIndex(e => new { e.IdAddressAutoComplete, e.IdSettings, e.First5 })
                    .HasName("missing_index_93_92");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.IdAgent)
                    .HasName("PK__Agent__D87D391F6E05AF45");
            });

            modelBuilder.Entity<AgentAvailability>(entity =>
            {
                entity.HasKey(e => e.IdAgentAvailability)
                    .HasName("PK__AgentAva__9477218B75A6D10D");

                entity.HasIndex(e => new { e.IdAgent, e.WeekDayName })
                    .HasName("UC_AgentAvailability")
                    .IsUnique();
            });

            modelBuilder.Entity<Agents>(entity =>
            {
                entity.HasIndex(e => e.AgentUserId)
                    .HasName("idAgentsFromAgentUserID");

                entity.HasIndex(e => e.Email)
                    .HasName("missing_index_2_1");

                entity.HasIndex(e => new { e.Deleted, e.IdSettings })
                    .HasName("Deleted_idSettings_Index");

                entity.HasIndex(e => new { e.MlsId, e.FirstName, e.LastName, e.IdSettings })
                    .HasName("MlsidIndex");

                entity.HasIndex(e => new { e.AgentUserId, e.MlsId, e.LeadAdmin, e.Cname, e.CitySpecial, e.TotalReferrals, e.LastReferral, e.CosReferrals, e.CosLast, e.TransferReferrals, e.CnameReferrals, e.CnameLast, e.ManualSelectCount, e.Email, e.TxtCarrier, e.Address, e.Address2, e.City, e.State, e.Zip, e.CellPhone1, e.CellPhone2, e.CellPhone3, e.OfficePhone1, e.OfficePhone2, e.OfficePhone3, e.TrackPhone1, e.TrackPhone2, e.TrackPhone3, e.Company, e.Position, e.FirstName, e.LastName, e.Picture, e.Visible, e.RentalLeads, e.TransferOut1, e.TransferOut2, e.TransferOut3, e.RentalAdmin, e.ImportedIdAgent, e.ContextIotoken, e.AgentSignature, e.Logo, e.ShowFeaturedListings, e.FaceBook, e.LinkedIn, e.Twitter, e.ActiveRain, e.Byline, e.Certifications, e.Awards, e.ShowAgentListings, e.CustomBackgroundImage, e.MoreInformation, e.Suffix, e.Suspended, e.GooglePlusAccount, e.TwitterHandle, e.YouTubeProfile, e.PinterestProfile, e.ShortBio, e.RentalsOnly, e.ApprovedBlogger, e.BetaTesting, e.AutoSearchOn, e.ZillowAgentId, e.UseNewAdmin, e.EditAgentSendNewLeadsSms, e.AgentTimeZone, e.AdminRightSideBarPosition, e.ImportLeadsFrom, e.AgentNumber, e.FollowUpBossApikey, e.FollowUpBossEnabled, e.GetProActiveNotifications, e.ProActNotAfter14DaysOn, e.ProActNotAfter14DaysEmail, e.ProActNotAfter14DaysTxt, e.ProActNotUncontactedLeadEmailClickOn, e.ProActNotUncontactedLeadEmailClickEmail, e.ProActNotUncontactedLeadEmailClickTxt, e.ProActNotRepeatedPropertyViewsOn, e.ProActNotRepeatedPropertyViewsEmail, e.ProActNotRepeatedPropertyViewsTxt, e.ProActNotSavedPropertyOn, e.ProActNotSavedPropertyEmail, e.ProActNotSavedPropertyTxt, e.ProActNotSavedSearchOn, e.ProActNotSavedSearchEmail, e.ProActNotSavedSearchTxt, e.ProActNotUserUnsubOn, e.ProActNotUserUnsubEmail, e.ProActNotUserUnsubTxt, e.ProActNotTimeframe30DaysLeftOn, e.ProActNotTimeframe30DaysLeftEmail, e.ProActNotTimeframe30DaysLeftTxt, e.ProActNotNewPartialLeadOn, e.ProActNotNewPartialLeadEmail, e.ProActNotNewPartialLeadTxt, e.SendImportedLeadsToQueue, e.SecondaryAgentNotificationAfter14DaysOn, e.SecondaryAgentNotificationAfter14DaysEmail, e.SecondaryAgentNotificationAfter14DaysTxt, e.SecondaryAgentNotificationUncontactedLeadEmailClickOn, e.SecondaryAgentNotificationUncontactedLeadEmailClickEmail, e.SecondaryAgentNotificationUncontactedLeadEmailClickTxt, e.SecondaryAgentNotificationRepeatedPropertyViewsOn, e.SecondaryAgentNotificationRepeatedPropertyViewsEmail, e.SecondaryAgentNotificationRepeatedPropertyViewsTxt, e.SecondaryAgentNotificationSavedPropertyOn, e.SecondaryAgentNotificationSavedPropertyEmail, e.SecondaryAgentNotificationSavedPropertyTxt, e.SecondaryAgentNotificationSavedSearchOn, e.SecondaryAgentNotificationSavedSearchEmail, e.SecondaryAgentNotificationSavedSearchTxt, e.SecondaryAgentNotificationUserUnsubOn, e.SecondaryAgentNotificationUserUnsubEmail, e.SecondaryAgentNotificationUserUnsubTxt, e.SecondaryAgentNotificationTimeframe30DaysLeftOn, e.SecondaryAgentNotificationTimeframe30DaysLeftEmail, e.SecondaryAgentNotificationTimeframe30DaysLeftTxt, e.SecondaryAgentNotificationNewPartialLeadOn, e.SecondaryAgentNotificationNewPartialLeadEmail, e.SecondaryAgentNotificationNewPartialLeadTxt, e.SecondaryAgentNotificationNewLeadAcceptOn, e.SecondaryAgentNotificationNewLeadAcceptEmail, e.SecondaryAgentNotificationNewLeadAcceptTxt, e.SecondaryAgentNotificationNewLeadDetailsOn, e.SecondaryAgentNotificationNewLeadDetailsEmail, e.SecondaryAgentNotificationNewLeadDetailsTxt, e.SecondaryAgentNotificationNewLeadAcceptFirstSecondaryGetsPrimary, e.DefaultSecondaryAgents, e.AgentReviewPageText, e.ZillowReviewsScreenName, e.CustomAutoSavedSearchSubject, e.CustomAutoSavedSearchBody, e.PinterestDomainVerify, e.GoogleOauthRefreshToken, e.GoogleOauthTokenGoodUntil, e.GoogleOauthToken, e.CustomAgentFeaturedPropetiesQuery, e.ProActNotEnableDripAutoPauseOn, e.ProActNotEnableDripAutoPauseTxt, e.ProActNotEnableDripAutoPauseEmail, e.SecondaryAgentNotificationAcceptIncomingSms, e.ThirdPartyNoAddressInitialSmstemplate, e.ThirdPartyAddressInitialSmstemplate, e.EditAgentSendThirdPartyLeadsInitialSms, e.ProActNotInboundSmsOn, e.ProActNotInboundSmsEmail, e.ProActNotInboundSmsTxt, e.SecondaryAgentNotificationAcceptIncomingSmsTxt, e.SecondaryAgentNotificationAcceptIncomingSmsEmail, e.SecondaryAgentNotificationAcceptIncomingSmsOn, e.IdAgent, e.Deleted, e.Status, e.IdSettings })
                    .HasName("idx_Deleted_Status_idSettings");

                entity.Property(e => e.AdminRightSideBarPosition).HasDefaultValueSql("1");

                entity.Property(e => e.ApprovedBlogger).HasDefaultValueSql("0");

                entity.Property(e => e.AutoSearchOn).HasDefaultValueSql("0");

                entity.Property(e => e.BetaTesting).HasDefaultValueSql("0");

                entity.Property(e => e.Cname).HasDefaultValueSql("''");

                entity.Property(e => e.CnameReferrals).HasDefaultValueSql("0");

                entity.Property(e => e.CosLast).HasDefaultValueSql("getdate()");

                entity.Property(e => e.CosReferrals).HasDefaultValueSql("0");

                entity.Property(e => e.CustomAutoSavedSearchBody).HasDefaultValueSql("''");

                entity.Property(e => e.CustomAutoSavedSearchSubject).HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.EditAgentSendNewLeadsSms).HasDefaultValueSql("0");

                entity.Property(e => e.EditAgentSendThirdPartyLeadsInitialSms).HasDefaultValueSql("0");

                entity.Property(e => e.FollowUpBossEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.GetProActiveNotifications).HasDefaultValueSql("1");

                entity.Property(e => e.LastReferral).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LeadAdmin).HasDefaultValueSql("0");

                entity.Property(e => e.ManualSelectCount).HasDefaultValueSql("0");

                entity.Property(e => e.Position).HasDefaultValueSql("0");

                entity.Property(e => e.ProActNotAfter14DaysEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotAfter14DaysOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotAfter14DaysTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotEnableDripAutoPauseEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotEnableDripAutoPauseOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotEnableDripAutoPauseTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotInboundSmsEmail).HasDefaultValueSql("0");

                entity.Property(e => e.ProActNotInboundSmsOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotInboundSmsTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotNewPartialLeadEmail).HasDefaultValueSql("0");

                entity.Property(e => e.ProActNotNewPartialLeadOn).HasDefaultValueSql("0");

                entity.Property(e => e.ProActNotNewPartialLeadTxt).HasDefaultValueSql("0");

                entity.Property(e => e.ProActNotRepeatedPropertyViewsEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotRepeatedPropertyViewsOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotRepeatedPropertyViewsTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedPropertyEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedPropertyOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedPropertyTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedSearchEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedSearchOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotSavedSearchTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotTimeframe30DaysLeftEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotTimeframe30DaysLeftOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotTimeframe30DaysLeftTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUncontactedLeadEmailClickEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUncontactedLeadEmailClickOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUncontactedLeadEmailClickTxt).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUserUnsubEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUserUnsubOn).HasDefaultValueSql("1");

                entity.Property(e => e.ProActNotUserUnsubTxt).HasDefaultValueSql("1");

                entity.Property(e => e.RentalAdmin).HasDefaultValueSql("0");

                entity.Property(e => e.RentalLeads).HasDefaultValueSql("1");

                entity.Property(e => e.RentalsOnly).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAcceptIncomingSms).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAcceptIncomingSmsEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAcceptIncomingSmsOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAcceptIncomingSmsTxt).HasDefaultValueSql("1");

                entity.Property(e => e.SecondaryAgentNotificationAfter14DaysEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAfter14DaysOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationAfter14DaysTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadAcceptEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadAcceptFirstSecondaryGetsPrimary).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadAcceptOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadAcceptTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadDetailsEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadDetailsOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewLeadDetailsTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewPartialLeadEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewPartialLeadOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationNewPartialLeadTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationRepeatedPropertyViewsEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationRepeatedPropertyViewsOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationRepeatedPropertyViewsTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedPropertyEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedPropertyOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedPropertyTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedSearchEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedSearchOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationSavedSearchTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationTimeframe30DaysLeftEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationTimeframe30DaysLeftOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationTimeframe30DaysLeftTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUncontactedLeadEmailClickEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUncontactedLeadEmailClickOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUncontactedLeadEmailClickTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUserUnsubEmail).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUserUnsubOn).HasDefaultValueSql("0");

                entity.Property(e => e.SecondaryAgentNotificationUserUnsubTxt).HasDefaultValueSql("0");

                entity.Property(e => e.SendImportedLeadsToQueue).HasDefaultValueSql("0");

                entity.Property(e => e.ShowAgentListings).HasDefaultValueSql("1");

                entity.Property(e => e.ShowFeaturedListings).HasDefaultValueSql("1");

                entity.Property(e => e.Status).HasDefaultValueSql("0");

                entity.Property(e => e.Suspended).HasDefaultValueSql("0");

                entity.Property(e => e.TextMessageConsent).HasDefaultValueSql("0");

                entity.Property(e => e.ThirdPartyAddressInitialSmstemplate).HasDefaultValueSql("'Hi _LeadFirstName, thanks for your inquiry on _Address, would you like to see it this weekend? _AgentFirstName'");

                entity.Property(e => e.ThirdPartyNoAddressInitialSmstemplate).HasDefaultValueSql("'Hi _LeadFirstName, _ThirdPartySource said I may be able to schedule some viewings for you. Anything in paticular you wanted to look at? _AgentFirstName'");

                entity.Property(e => e.TotalReferrals).HasDefaultValueSql("0");

                entity.Property(e => e.TransferReferrals).HasDefaultValueSql("0");

                entity.Property(e => e.TxtCarrier).HasDefaultValueSql("0");

                entity.Property(e => e.UseNewAdmin).HasDefaultValueSql("1");

                entity.Property(e => e.Visible).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<AndroidCloudMessagingRegistration>(entity =>
            {
                entity.HasKey(e => e.IdAndroidCloudMessagingRegistration)
                    .HasName("PK__AndroidC__9DED535B17FDF3A5");

                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUsed).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Areastatistics>(entity =>
            {
                entity.HasKey(e => e.IdAreaStatistics)
                    .HasName("PK_AreaStatistics");

                entity.HasIndex(e => e.IsMlsdc)
                    .HasName("Idx_IsMLSDC");

                entity.HasIndex(e => e.LastUpdate)
                    .HasName("Idx_LastUpdate");

                entity.HasIndex(e => new { e.City, e.State, e.CountyName, e.SubdivisionName, e.IsMlsdc })
                    .HasName("Idx_GetFrontEnd_PreCheck")
                    .IsUnique();

                entity.Property(e => e.IsMlsdc).HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.NeedsReCalc).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.Active, e.Created })
                    .HasName("missing_index_10_9_blog");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.IdAgent).HasDefaultValueSql("0");

                entity.Property(e => e.IdSettings).HasDefaultValueSql("0");

                entity.Property(e => e.ShareLevel).HasDefaultValueSql("2");

                entity.Property(e => e.Views).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BlogCategories>(entity =>
            {
                entity.Property(e => e.Lft).HasDefaultValueSql("0");

                entity.Property(e => e.Rgt).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CallLog>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("missing_index_1324_1323");
            });

            modelBuilder.Entity<CioDomainBodyElements>(entity =>
            {
                entity.HasKey(e => e.IdCioDomainBodyElements)
                    .HasName("PK__CIO_Doma__1A3A4F81047D01D8");

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CioDomainNameSubjectTest>(entity =>
            {
                entity.HasKey(e => e.IdCioDomainNameSubjectTest)
                    .HasName("PK__CIO_Doma__36CAD5CB0A35DB2E");

                entity.HasIndex(e => new { e.IdCioDomainNames, e.CioDomainNameSubjectTest1 })
                    .HasName("UC_CIO_DomainNameSubjectTest")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CioDomainNames>(entity =>
            {
                entity.HasKey(e => e.IdCioDomainNames)
                    .HasName("PK__CIO_Doma__4D5F37290FEEB484");

                entity.HasIndex(e => e.CioDomainNames1)
                    .HasName("UC_CIO_DomainNames")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CioFlag>(entity =>
            {
                entity.HasKey(e => e.IdCioFlag)
                    .HasName("PK__CIO_FLAG__41C50A2974469A0F");

                entity.HasIndex(e => e.CioFlag1)
                    .HasName("UC_CIO_Flag")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CioGmailPushInfo>(entity =>
            {
                entity.HasKey(e => e.IdCioGmailPushInfo)
                    .HasName("PK__CIO_Gmai__508D636853DEFC96");
            });

            modelBuilder.Entity<CioInfo>(entity =>
            {
                entity.HasKey(e => e.IdCioInfo)
                    .HasName("PK__CIO_Info__C9C27DBF6ABD2FD5");

                entity.HasIndex(e => e.CioInfoName)
                    .HasName("UC_CIO_Info_Name")
                    .IsUnique();
            });

            modelBuilder.Entity<CioTest>(entity =>
            {
                entity.HasKey(e => e.IdCioTest)
                    .HasName("PK__CIO_Test__AD55212B6504567F");

                entity.HasIndex(e => e.CioTestName)
                    .HasName("UC_CIO_Test_Name")
                    .IsUnique();
            });

            modelBuilder.Entity<Ciomessage>(entity =>
            {
                entity.HasKey(e => e.IdCiomessage)
                    .HasName("PK__CIOMessa__445FB0D579FF7365");
            });

            modelBuilder.Entity<CiomessageType>(entity =>
            {
                entity.HasKey(e => e.IdCiomessageType)
                    .HasName("PK__CIOMessa__6975C9777EC42882");

                entity.HasIndex(e => e.CiomessageType1)
                    .HasName("UC_CIOMessageType")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CitySubZip>(entity =>
            {
                entity.HasKey(e => e.IdCitySubZip)
                    .HasName("PK__CitySubZ__F9AA691267167D62");

                entity.HasIndex(e => new { e.City, e.SubdivisionName, e.ZipCode })
                    .HasName("CleanupRetsUpdateCitySubZip");

                entity.HasIndex(e => new { e.ZipCode, e.IdSettings, e.City })
                    .HasName("missing_index_11857_11856");

                entity.HasIndex(e => new { e.City, e.SubdivisionName, e.IdSettings, e.ZipCode })
                    .HasName("missing_index_88_87");

                entity.HasIndex(e => new { e.City, e.ZipCode, e.IdSettings, e.SubdivisionName })
                    .HasName("missing_index_86_85");

                entity.HasIndex(e => new { e.ZipCode, e.City, e.SubdivisionName, e.IdSettings })
                    .HasName("SearchBoxAutoComplete");
            });

            modelBuilder.Entity<CitySubZipTest>(entity =>
            {
                entity.HasKey(e => e.IdCitySubZip)
                    .HasName("PK__CitySubZ__F9AA691274FD951D");

                entity.Property(e => e.IdCitySubZip).ValueGeneratedNever();
            });

            modelBuilder.Entity<CleanupTable>(entity =>
            {
                entity.HasKey(e => e.IdCleanupTable)
                    .HasName("PK__CleanupT__DF77ECDD1DDBDAD5");

                entity.HasIndex(e => new { e.IdCleanupTable, e.Sysid, e.IdSettings, e.IdRetsSetting })
                    .HasName("RetsCleanup_idSettings_idRetsSetting");
            });

            modelBuilder.Entity<ClientAreas>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK__ClientAr__70B82028C1E9C3D0");

                entity.HasIndex(e => e.IdSettings)
                    .HasName("Idx_ClientAreas_idSettings");

                entity.HasIndex(e => new { e.IdSettings, e.Area })
                    .HasName("idSettings_City_ClientAreas");

                entity.HasIndex(e => new { e.IdSettings, e.City })
                    .HasName("idSettings_County_ClientAreas");

                entity.HasIndex(e => new { e.IdSettings, e.County })
                    .HasName("idSettings_ZipCode_ClientAreas");

                entity.HasIndex(e => new { e.IdSettings, e.ZipCode })
                    .HasName("idSettings_Area_ClientAreas");

                entity.Property(e => e.Selected).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("LeadDashIndex");

                entity.HasIndex(e => new { e.IdAgent, e.Subject })
                    .HasName("AgentDashboard");

                entity.HasIndex(e => new { e.IdSettings, e.Subject })
                    .HasName("missing_index_80639_80638");

                entity.HasIndex(e => new { e.IdAgent, e.Created, e.ContactType })
                    .HasName("AgentListIndex");

                entity.HasIndex(e => new { e.IdContact, e.IsPhone, e.PhoneType, e.IdLead })
                    .HasName("LeadPhoneIndex");

                entity.HasIndex(e => new { e.IdContact, e.IdLead, e.IdAgent, e.Subject, e.Created })
                    .HasName("HotList_Index");

                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedOffset).HasDefaultValueSql("sysdatetimeoffset()");

                entity.Property(e => e.IsPhone).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContextIoCluster>(entity =>
            {
                entity.HasKey(e => e.IdContextIoCluster)
                    .HasName("PK__ContextI__8FA887C47076092B");
            });

            modelBuilder.Entity<CountyAutoComplete>(entity =>
            {
                entity.HasIndex(e => new { e.CountyShort, e.IdSettings })
                    .HasName("IndexCountyShort");
            });

            modelBuilder.Entity<CustomPages>(entity =>
            {
                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.FullScreen).HasDefaultValueSql("0");

                entity.Property(e => e.Published).HasDefaultValueSql("0");

                entity.Property(e => e.Visibility).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CustomSearchListings1>(entity =>
            {
                entity.HasKey(e => e.IdCustomSearchListings)
                    .HasName("PK__tmp_ms_x__A27C44E12487A48B");
            });

            modelBuilder.Entity<CustomSeo>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.Active })
                    .HasName("missing_index_58_57");

                entity.HasIndex(e => new { e.Name, e.IdSettings, e.Active })
                    .HasName("Suggested_Seo_Pages");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.ReplaceMatched).HasDefaultValueSql("0");

                entity.Property(e => e.ShowDefaultText).HasDefaultValueSql("1");

                entity.Property(e => e.ShowProperties).HasDefaultValueSql("1");

                entity.Property(e => e.Views).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DailySeoCache>(entity =>
            {
                entity.HasIndex(e => e.Urlhash)
                    .HasName("URLHash_INDEX");

                entity.HasIndex(e => new { e.PageType, e.Urlhash, e.IdSettings, e.DateCreated })
                    .HasName("MetaData");
            });

            modelBuilder.Entity<DeletedListings>(entity =>
            {
                entity.HasIndex(e => new { e.City, e.SubdivisionName })
                    .HasName("CityHood");

                entity.HasIndex(e => new { e.City, e.State, e.SubdivisionName, e.Mlnumber, e.IdSettings })
                    .HasName("FindDeletedListing_ByMLNumberAndidSettings");

                entity.HasIndex(e => new { e.FullBaths, e.Bedrooms, e.ListPrice, e.SubType, e.Mlnumber })
                    .HasName("idx_MLNumber_plusIncdls");

                entity.HasIndex(e => new { e.ListingId, e.DateAdded, e.SchoolElemId, e.IdSettings, e.RentalListing })
                    .HasName("ix_DeletedListings_idSettings_RentalListing_includes");

                entity.HasIndex(e => new { e.ListingId, e.City, e.State, e.SubdivisionName, e.IdSettings, e.ListPrice })
                    .HasName("missing_index_100241_100240");

                entity.HasIndex(e => new { e.ListingId, e.ListPrice, e.Status, e.DateAdded, e.RentalListing, e.IdSettings })
                    .HasName("idx_RentalListing)IdSettings_plus");

                entity.HasIndex(e => new { e.ListingId, e.Status, e.DateAdded, e.RentalListing, e.IdSettings, e.ListPrice })
                    .HasName("idx_RentalListing_idSettings_ListPrice_PLUS");

                entity.HasIndex(e => new { e.ListingId, e.Status, e.SubType, e.DateAdded, e.RentalListing, e.IdSettings })
                    .HasName("idx_RentalListing_idSettings_plus");

                entity.HasIndex(e => new { e.ListingId, e.Status, e.SubdivisionName, e.DateAdded, e.RentalListing, e.IdSettings })
                    .HasName("ix_DeletedListings_RentalListing_idSettings_includes");

                entity.HasIndex(e => new { e.DateDeleted, e.RentalListing, e.City, e.State, e.IdSettings, e.ListPrice, e.DateAdded })
                    .HasName("ListPriceStats");

                entity.HasIndex(e => new { e.DateDeleted, e.RentalListing, e.State, e.CountyName, e.IdSettings, e.ListPrice, e.DateAdded })
                    .HasName("missing_index_347_346");

                entity.HasIndex(e => new { e.City, e.CountyName, e.SubdivisionName, e.DateDeleted, e.RentalListing, e.State, e.IdSettings, e.ListPrice, e.DateAdded })
                    .HasName("GetListPriceStatsIndex");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.FullBaths, e.InteriorFeature, e.ListPrice, e.LivAreaSqFt, e.Pool, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.LastTransDate, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.RentalListing, e.IdSettings })
                    .HasName("GetRecordsPaged");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.LastTransDate, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.HasBasement, e.RetirementCommunity, e.GatedCommunity, e.HasPool, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.FirePlace, e.HasWoodFloors, e.StreetName, e.TotalGarageSpaces, e.IdSettings, e.DateAdded })
                    .HasName("GetRecordsPaged02");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.ListAgentId, e.ListOfficeId, e.LastTransDate, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.RentalListing, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.StreetName, e.ThreeQuarterBaths, e.IdSettings })
                    .HasName("idx_IdSettings_Plus");

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.Indexed).HasDefaultValueSql("1");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DeletedSoldListings>(entity =>
            {
                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.Indexed).HasDefaultValueSql("1");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DripAssignment>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("idLead_DripAssignment");

                entity.HasIndex(e => new { e.IdLead, e.IdDripCampaign })
                    .HasName("missing_index_83802_83801");

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<DripCampaign>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.AutoPause).HasDefaultValueSql("1");

                entity.Property(e => e.IdAgent).HasDefaultValueSql("0");

                entity.Property(e => e.IdCompanyTrigger).HasDefaultValueSql("0");

                entity.Property(e => e.IdTorchXtrigger).HasDefaultValueSql("0");

                entity.Property(e => e.ShareLevel).HasDefaultValueSql("0");

                entity.Property(e => e.TotalEmailBounce).HasDefaultValueSql("0");

                entity.Property(e => e.TotalEmailClick).HasDefaultValueSql("0");

                entity.Property(e => e.TotalEmailOpen).HasDefaultValueSql("0");

                entity.Property(e => e.TotalEmailSent).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DripCampaignActivity>(entity =>
            {
                entity.HasIndex(e => e.IdDripAssignment)
                    .HasName("DripCampaignActivity_DripAssignment");

                entity.HasIndex(e => new { e.IdDripCampaignActivity, e.IdMandrill, e.SentTimeStamp, e.Subject, e.IdDripAssignment, e.NoticeRead, e.IdDripCampaignEvent })
                    .HasName("missing_index_167_166");

                entity.Property(e => e.NoticeRead).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DripCampaignEventTemplates>(entity =>
            {
                entity.HasIndex(e => new { e.IdDripCampaignEventTemplate, e.EventType })
                    .HasName("missing_index_105395_105394");

                entity.HasIndex(e => new { e.IdDripCampaignEventTemplate, e.EventSubject, e.EmailJson, e.EmailSent, e.EmailOpen, e.EmailClick, e.EventType, e.EventName, e.IdAgent, e.ShareLevel, e.EmailFormat, e.IdSettings })
                    .HasName("missing_index_155_154");

                entity.Property(e => e.EmailClick).HasDefaultValueSql("0");

                entity.Property(e => e.EmailFormat).HasDefaultValueSql("0");

                entity.Property(e => e.EmailOpen).HasDefaultValueSql("0");

                entity.Property(e => e.EmailSent).HasDefaultValueSql("0");

                entity.Property(e => e.EventType).HasDefaultValueSql("0");

                entity.Property(e => e.ShareLevel).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DripCampaignEvents>(entity =>
            {
                entity.HasIndex(e => e.IdDripCampaign)
                    .HasName("missing_index_656_655");

                entity.Property(e => e.EventSendAfter).HasDefaultValueSql("0");

                entity.Property(e => e.EventSendAfterSeconds).HasDefaultValueSql("0");

                entity.Property(e => e.EventSendAfterTime).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DripCampaignTrigger>(entity =>
            {
                entity.HasKey(e => e.IdDripCampaignTrigger)
                    .HasName("PK_CampaignTrigger");
            });

            modelBuilder.Entity<DripTriggers>(entity =>
            {
                entity.Property(e => e.IdAgent).HasDefaultValueSql("0");

                entity.Property(e => e.IdDripCampaign).HasDefaultValueSql("0");

                entity.Property(e => e.IdDripCampaignTrigger).HasDefaultValueSql("0");

                entity.Property(e => e.IdSettings).HasDefaultValueSql("0");

                entity.Property(e => e.TriggerLevel).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasIndex(e => new { e.IdLead, e.FromEmail })
                    .HasName("GetLeadsPagedFromEmailidLead");

                entity.HasIndex(e => new { e.LeadEmail, e.ToEmail })
                    .HasName("GetLeadsPagedV42_ToEmail");

                entity.HasIndex(e => new { e.IdLead, e.FromEmail, e.EmailRead })
                    .HasName("GetLeadsPagedCountFromEmail");

                entity.HasIndex(e => new { e.LeadEmail, e.ToEmail, e.IdLead })
                    .HasName("missing_index_10_9");

                entity.HasIndex(e => new { e.LeadEmail, e.FromEmail, e.ToEmail, e.IdLead })
                    .HasName("missing_index_653_652");

                entity.HasIndex(e => new { e.IdEmail, e.ToEmail, e.IdLead, e.IdSettings, e.EmailRead, e.DateReceived })
                    .HasName("EmailsForNotifications");

                entity.Property(e => e.EmailRead).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasIndex(e => new { e.GroupName, e.IdAgent })
                    .HasName("missing_index_3074_3073");

                entity.Property(e => e.DateLastLead).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ImportTemp>(entity =>
            {
                entity.HasKey(e => e.IdLead)
                    .HasName("PK_LeadsTemp");

                entity.Property(e => e.DateActivity).HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("getdate()");

                entity.Property(e => e.IdAgent).HasDefaultValueSql("3");

                entity.Property(e => e.NeedUser).HasDefaultValueSql("0");

                entity.Property(e => e.Status).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.IdLead)
                    .HasName("PK__Lead__1F30A14571D64029");
            });

            modelBuilder.Entity<LeadAssignments>(entity =>
            {
                entity.HasKey(e => e.IdLeadAssignment)
                    .HasName("PK__LeadAssi__8C30AAEA3E52545D");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent })
                    .HasName("LeadDashboard_Get_Backend_LeadDashboardTotals");

                entity.HasIndex(e => new { e.IdLead, e.IdLeadAssignment, e.IdAgent })
                    .HasName("LeadDashboard_AgentSeek");
            });

            modelBuilder.Entity<LeadDashboard>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("idLeadIndex");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.LeadHasUnreadEmail })
                    .HasName("missing_index_277889_277888");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.LeadLastOnline })
                    .HasName("missing_index_101712_101711");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.LeadStatus })
                    .HasName("missing_index_277887_277886");

                entity.HasIndex(e => new { e.IdLeadDash, e.IdLead, e.IdAgent, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.LeadPinned })
                    .HasName("missing_index_101718_101717");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.LeadTelephoneStatus, e.LeadEmailStatus, e.LeadLastActUtc })
                    .HasName("missing_index_81366_81365");

                entity.HasIndex(e => new { e.IdAgent, e.LeadLastOnline, e.LeadStatus, e.LeadTelephoneStatus, e.LeadEmailStatus, e.LeadLastActUtc, e.LeadHasUnreadEmail, e.LeadPinned, e.IdSettings })
                    .HasName("GetTotalsIndex");

                entity.HasIndex(e => new { e.IdLead, e.LeadHasUnreadEmail, e.LeadStatus, e.LeadLastOnline, e.LeadEmailStatus, e.LeadPinned, e.IdSettings, e.LeadDeleted, e.LeadIsHidden, e.IdAgent })
                    .HasName("LeadDashboard_Get_Backend_LeadDashboardTotals");

                entity.HasIndex(e => new { e.IdLeadDash, e.IdLead, e.IdAgent, e.LeadNumber, e.LeadIsHidden, e.LeadInCommunication, e.LeadPinned, e.UpdateDateUtc, e.LeadFirstName, e.LeadLastName, e.LeadTelephoneNumOnly, e.LeadTelephoneStatus, e.LeadEmail, e.LeadEmailStatus, e.LeadSphereType, e.LeadLookingForCity, e.LeadLookingForHood, e.LeadTransactionType, e.LeadSource, e.LeadReferral, e.LeadLandingPage, e.LeadRegisteredUtc, e.LeadLastActUtc, e.LeadAveragePrice, e.LeadLastTouchDate, e.LeadAverageBeds, e.LeadAverageBaths, e.LeadAveragePropertyType, e.LeadLastCallTxtDateTimeUtc, e.LeadHasUnreadEmail, e.LeadDripCampaignId, e.LeadStatus, e.LeadTimeFrameEndUtc, e.LeadTimeFrameType, e.LeadNextReminderId, e.LeadUnsubscribed, e.LeadNextReminderDateUtc, e.NoSms, e.UnsubscribedSent, e.LeadDeleted, e.IdSettings })
                    .HasName("LeadDashboard_DeletedLeadIndex");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.IdSettings, e.LeadNumber, e.LeadDeleted, e.LeadLastOnline, e.LeadIsHidden, e.LeadInCommunication, e.LeadPinned, e.UpdateDateUtc, e.LeadFirstName, e.LeadLastName, e.LeadTelephone, e.LeadTelephoneNumOnly, e.LeadTelephoneStatus, e.LeadEmail, e.LeadEmailStatus, e.LeadLookingForCity, e.LeadLookingForHood, e.LeadTransactionType, e.LeadSource, e.LeadReferral, e.LeadLandingPage, e.LeadFacebookId, e.LeadRegisteredUtc, e.LeadLastActUtc, e.LeadPropertiesViewed, e.LeadAveragePrice, e.LeadAverageBeds, e.LeadAverageBaths, e.LeadAveragePropertyType, e.LeadPropertiesSaved, e.LeadSearchesConducted, e.LeadAutoSavedSearches, e.LeadAgentSavedSearches, e.LeadUserSavedSearches, e.LeadSavedSearchTypes, e.LeadSuccessfullCalls, e.LeadFailedCalls, e.LeadTxtsent, e.LeadTxtreceived, e.LeadLastCallTxtDateTimeUtc, e.LeadLastCallTxtType, e.LeadLastCallTxtDetail, e.LeadEmailsSent, e.LeadEmailsOpened, e.LeadEmailsClicked, e.LeadEmailsReceived, e.LeadLastEmailDateUtc, e.LeadLastEmailDetail, e.LeadHasUnreadEmail, e.LeadDripCampaignAssignedUtc, e.LeadDripCampaignName, e.LeadDripCampaignActive, e.LeadDripCampaignId, e.LeadStatus, e.LeadTimeFrameEndUtc, e.LeadTimeFrameType, e.LeadPrimaryAgentName, e.LeadSecondaryAgentNames, e.LeadSecondaryAgentIds, e.LeadAgentLastActivityUtc, e.LeadAgentLastActivityDetail, e.LeadNextReminderDateUtc, e.LeadNextReminderDetail, e.LeadNextReminderId, e.LeadNextReminderType, e.LeadUpcomingReminderCount, e.LeadProNoteCount, e.LeadProNoteUtc, e.LeadProNoteDetail, e.LeadNoteCount, e.LeadNoteUtc, e.LeadNoteDetail, e.IdLeadStage, e.LeadStageCurrentStep, e.LeadStageSteps, e.LeadLastTouchDate, e.LeadTotalTouches, e.IdLeadDash })
                    .HasName("LeadDashboard_SearchPhase2");

                entity.HasIndex(e => new { e.IdLeadDash, e.IdLead, e.IdAgent, e.IdSettings, e.LeadNumber, e.LeadDeleted, e.LeadUnsubscribed, e.LeadLastOnline, e.LeadIsHidden, e.LeadInCommunication, e.LeadPinned, e.UpdateDateUtc, e.LeadFirstName, e.LeadLastName, e.LeadTelephone, e.LeadTelephoneNumOnly, e.LeadTelephoneStatus, e.LeadEmail, e.LeadEmailStatus, e.LeadSphereType, e.LeadLookingForCity, e.LeadLookingForHood, e.LeadTransactionType, e.LeadSource, e.LeadReferral, e.LeadLandingPage, e.LeadFacebookId, e.LeadRegisteredUtc, e.LeadLastActUtc, e.LeadPropertiesViewed, e.LeadAveragePrice, e.LeadLastTouchDate, e.LeadTotalTouches, e.LeadAverageBeds, e.LeadAverageBaths, e.LeadAveragePropertyType, e.LeadPropertiesSaved, e.LeadSearchesConducted, e.LeadAutoSavedSearches, e.LeadAgentSavedSearches, e.LeadUserSavedSearches, e.LeadSavedSearchTypes, e.LeadSuccessfullCalls, e.LeadFailedCalls, e.LeadTxtsent, e.LeadTxtreceived, e.LeadLastCallTxtDateTimeUtc, e.LeadLastCallTxtType, e.LeadLastCallTxtDetail, e.LeadEmailsSent, e.LeadEmailsOpened, e.LeadEmailsClicked, e.LeadEmailsReceived, e.LeadLastEmailDateUtc, e.LeadLastEmailDetail, e.LeadHasUnreadEmail, e.LeadDripCampaignAssignedUtc, e.LeadDripCampaignName, e.LeadDripCampaignActive, e.LeadDripCampaignId, e.LeadStatus, e.LeadTimeFrameEndUtc, e.LeadTimeFrameType, e.LeadPrimaryAgentName, e.LeadSecondaryAgentNames, e.LeadSecondaryAgentIds, e.LeadAgentLastActivityUtc, e.LeadAgentLastActivityDetail, e.LeadNextReminderDateUtc, e.LeadNextReminderDetail, e.LeadNextReminderId, e.LeadNextReminderType, e.LeadUpcomingReminderCount, e.LeadProNoteUtc, e.LeadProNoteDetail, e.LeadNoteCount, e.LeadNoteUtc, e.LeadNoteDetail, e.IdLeadStage, e.LeadStageCurrentStep, e.LeadStageSteps, e.LeadTags, e.LeadProNoteCount, e.AveragesCalculated, e.LeadLastTouchOffset, e.LeadProNoteOffset, e.LeadNoteOffset, e.LeadLastCallTxtDateTimeOffset, e.IdPartialLead })
                    .HasName("missing_index_87049_87048");

                entity.Property(e => e.AveragesCalculated).HasDefaultValueSql("0");

                entity.Property(e => e.IdLeadStage).HasDefaultValueSql("0");

                entity.Property(e => e.LeadAgentLastActivityDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadAgentSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.LeadAutoSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.LeadAverageBaths).HasDefaultValueSql("0");

                entity.Property(e => e.LeadAverageBeds).HasDefaultValueSql("0");

                entity.Property(e => e.LeadAveragePrice).HasDefaultValueSql("0");

                entity.Property(e => e.LeadDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.LeadDripCampaignActive).HasDefaultValueSql("0");

                entity.Property(e => e.LeadDripCampaignId).HasDefaultValueSql("0");

                entity.Property(e => e.LeadDripCampaignName).HasDefaultValueSql("''");

                entity.Property(e => e.LeadEmail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadEmailStatus).HasDefaultValueSql("0");

                entity.Property(e => e.LeadEmailsClicked).HasDefaultValueSql("0");

                entity.Property(e => e.LeadEmailsOpened).HasDefaultValueSql("0");

                entity.Property(e => e.LeadEmailsReceived).HasDefaultValueSql("0");

                entity.Property(e => e.LeadEmailsSent).HasDefaultValueSql("0");

                entity.Property(e => e.LeadFacebookId).HasDefaultValueSql("''");

                entity.Property(e => e.LeadFailedCalls).HasDefaultValueSql("0");

                entity.Property(e => e.LeadFirstName).HasDefaultValueSql("''");

                entity.Property(e => e.LeadHasUnreadEmail).HasDefaultValueSql("0");

                entity.Property(e => e.LeadInCommunication).HasDefaultValueSql("0");

                entity.Property(e => e.LeadIsHidden).HasDefaultValueSql("0");

                entity.Property(e => e.LeadLandingPage).HasDefaultValueSql("''");

                entity.Property(e => e.LeadLastActUtc).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LeadLastCallTxtDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadLastCallTxtType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadLastEmailDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadLastName).HasDefaultValueSql("''");

                entity.Property(e => e.LeadLastOnline).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LeadNextReminderDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadNextReminderId).HasDefaultValueSql("0");

                entity.Property(e => e.LeadNextReminderType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadNoteCount).HasDefaultValueSql("0");

                entity.Property(e => e.LeadNoteDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadPinned).HasDefaultValueSql("0");

                entity.Property(e => e.LeadPrimaryAgentName).HasDefaultValueSql("''");

                entity.Property(e => e.LeadProNoteCount).HasDefaultValueSql("0");

                entity.Property(e => e.LeadProNoteDetail).HasDefaultValueSql("''");

                entity.Property(e => e.LeadPropertiesSaved).HasDefaultValueSql("0");

                entity.Property(e => e.LeadPropertiesViewed).HasDefaultValueSql("0");

                entity.Property(e => e.LeadReferral).HasDefaultValueSql("''");

                entity.Property(e => e.LeadRegisteredUtc).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LeadSavedSearchTypes).HasDefaultValueSql("''");

                entity.Property(e => e.LeadSearchesConducted).HasDefaultValueSql("0");

                entity.Property(e => e.LeadSecondaryAgentIds).HasDefaultValueSql("''");

                entity.Property(e => e.LeadSecondaryAgentNames).HasDefaultValueSql("''");

                entity.Property(e => e.LeadSource).HasDefaultValueSql("0");

                entity.Property(e => e.LeadSphereType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadStageCurrentStep).HasDefaultValueSql("0");

                entity.Property(e => e.LeadStageSteps).HasDefaultValueSql("''");

                entity.Property(e => e.LeadStatus).HasDefaultValueSql("0");

                entity.Property(e => e.LeadSuccessfullCalls).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTags).HasDefaultValueSql("''");

                entity.Property(e => e.LeadTelephone).HasDefaultValueSql("''");

                entity.Property(e => e.LeadTelephoneNumOnly).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTelephoneStatus).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTimeFrameType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTotalTouches).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTransactionType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTxtreceived).HasDefaultValueSql("0");

                entity.Property(e => e.LeadTxtsent).HasDefaultValueSql("0");

                entity.Property(e => e.LeadUnsubscribed).HasDefaultValueSql("0");

                entity.Property(e => e.LeadUpcomingReminderCount).HasDefaultValueSql("0");

                entity.Property(e => e.LeadUserSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.NoSms).HasDefaultValueSql("0");

                entity.Property(e => e.UnsubscribedSent).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateDateUtc).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<LeadDetails>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("missing_index_1882_1881_LeadDetails");

                entity.Property(e => e.TimeFrame).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LeadTags>(entity =>
            {
                entity.HasIndex(e => new { e.IdLeadTag, e.IdLead })
                    .HasName("LeadTags_idLead");
            });

            modelBuilder.Entity<LeadTouches>(entity =>
            {
                entity.HasIndex(e => e.IdLead)
                    .HasName("missing_index_659_658");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent })
                    .HasName("LeadTouches_LookByidAgent_UserList");

                entity.HasIndex(e => new { e.IdLead, e.LeadTouchDateTimeOffset, e.IdSettings, e.TouchType })
                    .HasName("LeadTouches_LookByIdleadIdSettings_UserList");
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.HasIndex(e => e.IdRule)
                    .HasName("idx_idRule");

                entity.HasIndex(e => e.IdUser)
                    .HasName("missing_index_1884_1883_Leads");

                entity.HasIndex(e => new { e.AcceptKey, e.IdSettings })
                    .HasName("missing_index_82153_82152");

                entity.HasIndex(e => new { e.IdAgent, e.Telephone1 })
                    .HasName("GetAgent_Phone_For_Incoming_Call_Index");

                entity.HasIndex(e => new { e.IdUser, e.IdSettings })
                    .HasName("Idx_idUser_idSetting")
                    .IsUnique();

                entity.HasIndex(e => new { e.LeadDetailType, e.IdSettings })
                    .HasName("missing_index_86627_86626");

                entity.HasIndex(e => new { e.DateCreated, e.CreatedDateTimeOffset, e.IdSettings })
                    .HasName("DateCreatedIndexBrokerDashboard");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.CreatedDateTimeOffset })
                    .HasName("Leads_LookupByCreatedDateTimeOffset");

                entity.HasIndex(e => new { e.IdLead, e.IdUser, e.IdAgent, e.Email, e.Status })
                    .HasName("idx_a");

                entity.HasIndex(e => new { e.IdLead, e.IdUser, e.IdSettings, e.DateActivity, e.ActivityDateTimeOffset })
                    .HasName("GetLeadLogData_DateActivity");

                entity.HasIndex(e => new { e.IdLead, e.Telephone1, e.Email, e.FacebookId, e.FirstName, e.LastName, e.IdAgent })
                    .HasName("missing_index_81873_81872");

                entity.HasIndex(e => new { e.IdLead, e.Telephone1, e.Email, e.FacebookId, e.FirstName, e.LastName, e.IdSettings, e.IdAgent })
                    .HasName("missing_index_81877_81876");

                entity.HasIndex(e => new { e.IdLead, e.IdUser, e.IdAgent, e.DateActivity, e.ActivityDateTimeOffset, e.Email, e.Status, e.AveragePrice, e.ListingsViewed, e.LastName, e.LeadNumber, e.DateCreated, e.CreatedDateTimeOffset, e.LeadType, e.TimeFrameEnd, e.LastPhoneCall, e.IdSettings, e.Deleted })
                    .HasName("idSettingsIndex");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.DateCreated, e.CreatedDateTimeOffset, e.DateActivity, e.ActivityDateTimeOffset, e.Email, e.Status, e.AveragePrice, e.FirstName, e.LastName, e.LeadNumber, e.LeadType, e.Sticky, e.TimeFrameEnd, e.LastPhoneCall, e.UpdateTimeStamp, e.IdSettings, e.Deleted })
                    .HasName("idSettingsAndDeleted");

                entity.HasIndex(e => new { e.IdLead, e.IdAgent, e.DateCreated, e.CreatedDateTimeOffset, e.DateActivity, e.ActivityDateTimeOffset, e.Telephone1, e.Email, e.Status, e.AveragePrice, e.FirstName, e.LastName, e.IdSettings, e.LeadNumber, e.LeadType, e.Sticky, e.TimeFrameEnd, e.LastPhoneCall, e.UpdateTimeStamp, e.Deleted })
                    .HasName("TEMP_GetRecordsPagedV42_EmergencyFix");

                entity.Property(e => e.AgentSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.AutoSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.AverageBathsViewed).HasDefaultValueSql("0");

                entity.Property(e => e.AverageBedsViewed).HasDefaultValueSql("0");

                entity.Property(e => e.BadEmail).HasDefaultValueSql("0");

                entity.Property(e => e.DateActivity).HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.EmailVerified).HasDefaultValueSql("0");

                entity.Property(e => e.FacebookId).HasDefaultValueSql("''");

                entity.Property(e => e.FacebookPic).HasDefaultValueSql("''");

                entity.Property(e => e.IdAgent).HasDefaultValueSql("0");

                entity.Property(e => e.InCommunication).HasDefaultValueSql("0");

                entity.Property(e => e.IsHidden).HasDefaultValueSql("0");

                entity.Property(e => e.LastListingsViewedUpdate).HasDefaultValueSql("'1970-01-01'");

                entity.Property(e => e.LastOnline).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastPhoneCall).HasDefaultValueSql("'1970-01-01'");

                entity.Property(e => e.LeadSource).HasDefaultValueSql("3");

                entity.Property(e => e.LeadSphereType).HasDefaultValueSql("0");

                entity.Property(e => e.LeadType).HasDefaultValueSql("0");

                entity.Property(e => e.NeedsFinance).HasDefaultValueSql("0");

                entity.Property(e => e.NoSms).HasDefaultValueSql("0");

                entity.Property(e => e.Phone1NumbersOnly)
                    .HasComputedColumnSql("[dbo].[udf_GetNumeric]([telephone1])")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PhoneCallFails).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneCallSuccesses).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneVerified).HasDefaultValueSql("0");

                entity.Property(e => e.ReminderEmailSent).HasDefaultValueSql("0");

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.Sticky).HasDefaultValueSql("0");

                entity.Property(e => e.TimeFrameType).HasDefaultValueSql("0");

                entity.Property(e => e.TotalTouches).HasDefaultValueSql("0");

                entity.Property(e => e.TransactionType).HasDefaultValueSql("0");

                entity.Property(e => e.Unfollowed).HasDefaultValueSql("0");

                entity.Property(e => e.Unsubscribed).HasDefaultValueSql("0");

                entity.Property(e => e.UnsubscribedSent).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("getdate()");

                entity.Property(e => e.UserSavedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.UsrWelcomeMsg).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LeadsToProcssTableWork>(entity =>
            {
                entity.HasIndex(e => e.Dateactivity)
                    .HasName("idx_dateactivity");

                entity.HasIndex(e => e.IdUser)
                    .HasName("idx_idUser");

                entity.HasIndex(e => new { e.IdLead, e.IdSettings })
                    .HasName("idx_idSettings_plus");
            });

            modelBuilder.Entity<ListPriceHistory>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.AddressCityStateHash })
                    .HasName("HashIndex");

                entity.HasIndex(e => new { e.Mlnumber, e.IdSettings, e.PriceDate })
                    .HasName("MLNumber_Index");

                entity.HasIndex(e => new { e.PriceDate, e.IdSettings, e.Mlnumber })
                    .HasName("GetRecordPaged_EmailUpdates");

                entity.Property(e => e.EventType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ListingAlerts>(entity =>
            {
                entity.Property(e => e.SentTimestamp).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ListingCustomContent>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.Mlnumber })
                    .HasName("SearchByMLNumber");
            });

            modelBuilder.Entity<ListingDesigns>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_ListingDesigns_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ListingLotDesc>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_ListingLotDesc_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ListingRoofs>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_ListingRoofs_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ListingWaterfrontDescs1>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_ListingWaterfrontDescs_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Listings>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_TorchxGID");

                entity.HasIndex(e => e.City)
                    .HasName("Idx_City");

                entity.HasIndex(e => e.CountyName)
                    .HasName("Idx_County");

                entity.HasIndex(e => e.GeoArea)
                    .HasName("Idx_Area");

                entity.HasIndex(e => e.Mlnumber)
                    .HasName("LookupByMLNumber");

                entity.HasIndex(e => e.SubdivisionName)
                    .HasName("Idx_SubdivisionName");

                entity.HasIndex(e => e.ZipCode)
                    .HasName("Idx_Zipcode");

                entity.HasIndex(e => new { e.Address, e.StreetName, e.MlslookUpId, e.TorchxGid })
                    .HasName("Update_StreetNameAutoComplete");

                entity.HasIndex(e => new { e.Address, e.City, e.ZipCode, e.LastTransDate, e.State, e.Longitude, e.Latitude, e.TorchxGid, e.LastGeocodeAttempt })
                    .HasName("Get_GeoCodingInformation");

                entity.HasIndex(e => new { e.City, e.State, e.CountyName, e.SubType, e.SubdivisionName, e.Longitude, e.Latitude, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.LonRad, e.LatRad, e.RentalListing, e.ListPrice })
                    .HasName("Idx_Cache_AreaStats_Compute");

                entity.HasIndex(e => new { e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.LastTransDate, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.OriginalSubdivisionName, e.HasImage, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.HasBasement, e.RetirementCommunity, e.GatedCommunity, e.HasPool, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.FirePlace, e.HasWoodFloors, e.StreetName, e.TotalGarageSpaces, e.HasGuardedGate, e.DateTimeOffsetAdded, e.TorchxGid, e.DateAdded })
                    .HasName("GetRecordsPaged02");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.Bedrooms).HasDefaultValueSql("0");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("getdate()");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.ForeclosureYn).HasDefaultValueSql("0");

                entity.Property(e => e.FullBaths).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasImage).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.ImageCount).HasDefaultValueSql("0");

                entity.Property(e => e.ImageDownloadAttempts).HasDefaultValueSql("0");

                entity.Property(e => e.Indexed).HasDefaultValueSql("1");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsSold).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.LatRad).HasDefaultValueSql("0");

                entity.Property(e => e.Latitude).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LonRad).HasDefaultValueSql("0");

                entity.Property(e => e.Longitude).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.PartialImageDownload).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasDefaultValueSql("'FL'");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Listings1>(entity =>
            {
                entity.HasIndex(e => e.Address)
                    .HasName("AddressIndex");

                entity.HasIndex(e => e.IdSettings)
                    .HasName("idSettingsIndex");

                entity.HasIndex(e => e.ListAgentId)
                    .HasName("ListAgentIdIndex");

                entity.HasIndex(e => new { e.HasGuardedGate, e.IdSettings })
                    .HasName("HasGuardedGate");

                entity.HasIndex(e => new { e.IdRetsClass, e.LastImgTransDate })
                    .HasName("missing_index_85413_85412");

                entity.HasIndex(e => new { e.IdRetsClass, e.LastTransDate })
                    .HasName("RealTimeUpdate_LastTransDate");

                entity.HasIndex(e => new { e.IdRetsSetting, e.LastTransDate })
                    .HasName("RealtimeUpdate_LastTransDateBy_idRetsSetting");

                entity.HasIndex(e => new { e.IdSettings, e.Sysid })
                    .HasName("ix_Listings_idSettings_sysid");

                entity.HasIndex(e => new { e.LastImageDownload, e.IdRetsSetting })
                    .HasName("LastImageDownload_By_idRetsSetting");

                entity.HasIndex(e => new { e.City, e.Mlnumber, e.IdSettings })
                    .HasName("TEMP_GetLeadsPagedV42_StopGap");

                entity.HasIndex(e => new { e.IdSettings, e.DateAdded, e.ListingId })
                    .HasName("GetListingNextPreviousNoWhere");

                entity.HasIndex(e => new { e.IdSettings, e.Latitude, e.Longitude })
                    .HasName("idSettings_LatLong");

                entity.HasIndex(e => new { e.ListingId, e.IsNew, e.IdRetsClass })
                    .HasName("RealtimeUpdates_ResetNewBit");

                entity.HasIndex(e => new { e.Sysid, e.IdSettings, e.IdRetsSetting })
                    .HasName("Rets_CleanupRetsFeedAndGetMissing");

                entity.HasIndex(e => new { e.ListingId, e.City, e.IsNew, e.IdRetsSetting })
                    .HasName("missing_index_99921_99920");

                entity.HasIndex(e => new { e.ListingId, e.CountyName, e.IsNew, e.IdRetsSetting })
                    .HasName("ix_Listings_CountyName_IsNew_idRetsSetting_includes");

                entity.HasIndex(e => new { e.ListingId, e.IdSettings, e.LonRad, e.LatRad })
                    .HasName("ix_Listings_idSettings_Lon_Rad_Lat_Rad_includes");

                entity.HasIndex(e => new { e.ListingId, e.ListOfficeName, e.RentalListing, e.IdSettings })
                    .HasName("FeaturedListings_Rental_idSettings");

                entity.HasIndex(e => new { e.ListingId, e.SchoolElem, e.IsNew, e.IdRetsSetting })
                    .HasName("ix_Listings_IsNew_idRetsSetting_includes");

                entity.HasIndex(e => new { e.ListingId, e.SchoolHigh, e.IsNew, e.IdRetsSetting })
                    .HasName("idx_Listings_IsNew_idRetsSetting_includes");

                entity.HasIndex(e => new { e.ListingId, e.SchoolMid, e.IsNew, e.IdRetsSetting })
                    .HasName("missing_index_279234_279233");

                entity.HasIndex(e => new { e.ListingId, e.SubdivisionName, e.IsNew, e.IdRetsSetting })
                    .HasName("missing_index_99721_99720");

                entity.HasIndex(e => new { e.LonRad, e.LatRad, e.IdSettings, e.ListPrice })
                    .HasName("LatLonRad");

                entity.HasIndex(e => new { e.City, e.State, e.CountyName, e.SubdivisionName, e.LastTransDate })
                    .HasName("Idx_LastTransDate_C_S_C_S");

                entity.HasIndex(e => new { e.City, e.State, e.SubdivisionName, e.RentalListing, e.IdSettings })
                    .HasName("ix_Listings_RentalListing_idSettings_includes");

                entity.HasIndex(e => new { e.City, e.SubdivisionName, e.Latitude, e.IdSettings, e.Longitude })
                    .HasName("ix_Listings_idSettings_Longitude_includes");

                entity.HasIndex(e => new { e.FullBaths, e.Bedrooms, e.ListPrice, e.SubType, e.Mlnumber })
                    .HasName("idx_MLNumber_plusa");

                entity.HasIndex(e => new { e.ListingId, e.Address, e.StreetName, e.IsNew, e.IdRetsSetting })
                    .HasName("RealTimeUpdate_StreetNameAutoCompleteUpdate");

                entity.HasIndex(e => new { e.ListingId, e.IdRetsSetting, e.IdRetsClass, e.IdSettings, e.Address })
                    .HasName("RealtimeUpdates_AddressAutoComplete");

                entity.HasIndex(e => new { e.ListingId, e.IdRetsSetting, e.IdRetsClass, e.IdSettings, e.Mlnumber })
                    .HasName("RealtimeUpdates_MLSAutoComplete");

                entity.HasIndex(e => new { e.ListingId, e.IdSettings, e.IsNew, e.IdRetsSetting, e.Design })
                    .HasName("RealTimeUpdates_Designs");

                entity.HasIndex(e => new { e.ListingId, e.IsReo, e.IsNew, e.IdRetsSetting, e.SpecialInformation })
                    .HasName("ix_Listings_IsNew_idRetsSetting_SpecialInformation_includes");

                entity.HasIndex(e => new { e.ListingId, e.ListOfficeId, e.DateAdded, e.RentalListing, e.IdSettings })
                    .HasName("IX_Listings_RentalListing_IdSettings");

                entity.HasIndex(e => new { e.ListingId, e.LonRad, e.LatRad, e.RentalListing, e.IdSettings })
                    .HasName("SimilarListingsByDistance");

                entity.HasIndex(e => new { e.ListingId, e.RentalListing, e.IdSettings, e.LonRad, e.LatRad })
                    .HasName("ix_Listings_RentalListing_idSettings_Lon_Rad_Lat_Rad_includes");

                entity.HasIndex(e => new { e.ListingId, e.Status, e.IsNew, e.IdRetsSetting, e.MinimumDaysLease })
                    .HasName("ix_Listings_Status_IsNew_idRetsSetting_MinimumDaysLease_includes");

                entity.HasIndex(e => new { e.Mlnumber, e.IdSettings, e.ListingId, e.IdRetsSetting, e.IdRetsClass })
                    .HasName("RealTimeUpdates_GetUniqueMLNumberList");

                entity.HasIndex(e => new { e.Mlnumber, e.OldMlnumber, e.Sysid, e.ListingId, e.IdSettings })
                    .HasName("ListingPullWithOldMLNumber");

                entity.HasIndex(e => new { e.City, e.State, e.CountyName, e.SubType, e.SubdivisionName, e.ListPrice })
                    .HasName("Idx_Cache_AreaStats_TopSubTypes");

                entity.HasIndex(e => new { e.ImageCount, e.LastImgTransDate, e.LastImageDownload, e.LastTransDate, e.ImageDownloadAttempts, e.IdSettings })
                    .HasName("missing_index_215549_215548_Listings");

                entity.HasIndex(e => new { e.LastImgTransDate, e.LastImageDownload, e.ImageDownloadAttempts, e.PartialImageDownload, e.IdSettings, e.ImageCount })
                    .HasName("mcq_get_missing_image_count");

                entity.HasIndex(e => new { e.ListingId, e.Design, e.Roof, e.WaterfrontDesc, e.LotDescription, e.IdSettings })
                    .HasName("DesignRoofWaterfrontDescLotDescription_Index");

                entity.HasIndex(e => new { e.ListingId, e.PrivatePoolDescription, e.HasPool, e.IsNew, e.IdRetsSetting, e.SpecialInformation })
                    .HasName("idx_IsNew_idRetsSetting__Plus");

                entity.HasIndex(e => new { e.ListingId, e.SubType, e.AttachedType, e.IdRetsClass, e.IsNew, e.IdRetsSetting })
                    .HasName("missing_index_99738_99737");

                entity.HasIndex(e => new { e.City, e.CountyName, e.SubType, e.SubdivisionName, e.State, e.IdSettings, e.ListPrice })
                    .HasName("Get_Frontend_AreaStatistics_Index");

                entity.HasIndex(e => new { e.City, e.State, e.DateDeleted, e.RentalListing, e.IdSettings, e.ListPrice, e.DateAdded })
                    .HasName("ix_Listings_idSettings_ListPrice_DateAdded_includes");

                entity.HasIndex(e => new { e.DateDeleted, e.DateAdded, e.RentalListing, e.City, e.State, e.IdSettings, e.ListPrice })
                    .HasName("ListPriceStats");

                entity.HasIndex(e => new { e.ListingId, e.Address, e.Mlnumber, e.ZipCode, e.SubType, e.City, e.ListPrice })
                    .HasName("SuggestedIndex01");

                entity.HasIndex(e => new { e.ListingId, e.SubType, e.Status, e.IdRetsClass, e.IsNew, e.IdSettings, e.IdRetsSetting })
                    .HasName("RealTimeUpdates_IsNew_idRetsSettings");

                entity.HasIndex(e => new { e.ListingId, e.CountyName, e.ListPrice, e.Status, e.DateAdded, e.RentalListing, e.IdSettings, e.HasImage })
                    .HasName("missing_index_99689_99688");

                entity.HasIndex(e => new { e.ListingId, e.ImageCount, e.Mlnumber, e.LastImageDownload, e.HasImage, e.ImageDownloadAttempts, e.PartialImageDownload, e.IdSettings })
                    .HasName("missing_index_99603_99602");

                entity.HasIndex(e => new { e.ListingId, e.SchoolElem, e.SchoolElemId, e.SchoolMid, e.SchoolMidId, e.SchoolHigh, e.SchoolHighId, e.IdSettings })
                    .HasName("Listings_Schoolupdate");

                entity.HasIndex(e => new { e.City, e.SubType, e.SubdivisionName, e.PropertyType, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.Status, e.IdSettings })
                    .HasName("missing_index_99609_99608");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.FullBaths, e.ListPrice, e.SubType, e.Longitude, e.Latitude, e.IdSettings, e.Mlnumber })
                    .HasName("Listings_Get_FrontEnd_SimilarProperties");

                entity.HasIndex(e => new { e.ListingId, e.FullBaths, e.ListPrice, e.Status, e.DateAdded, e.ThreeQuarterBaths, e.RentalListing, e.IdSettings, e.Bedrooms })
                    .HasName("missing_index_99702_99701");

                entity.HasIndex(e => new { e.Address, e.City, e.State, e.CountyName, e.ListPrice, e.Mlnumber, e.SubdivisionName, e.ZipCode, e.LastImageDownload, e.IdSettings })
                    .HasName("ix_Listings_idSettings_includes");

                entity.HasIndex(e => new { e.Latitude, e.Longitude, e.City, e.State, e.ZipCode, e.Mlnumber, e.ListingId, e.LastTransDate, e.LastGeocodeAttempt, e.Address })
                    .HasName("ListingClientMapping2");

                entity.HasIndex(e => new { e.ListingId, e.City, e.FullBaths, e.ListPrice, e.Status, e.DateAdded, e.ThreeQuarterBaths, e.RentalListing, e.IdSettings, e.HasImage })
                    .HasName("missing_index_99888_99887");

                entity.HasIndex(e => new { e.ListingId, e.City, e.FullBaths, e.ListPrice, e.Status, e.SubType, e.ThreeQuarterBaths, e.RentalListing, e.IdSettings, e.Bedrooms })
                    .HasName("idx_comp1a");

                entity.HasIndex(e => new { e.Sysid, e.Mlnumber, e.LastImgTransDate, e.LastTransDate, e.ImageDownloadAttempts, e.ImageCount, e.PartialImageDownload, e.IdSettings, e.IdRetsSetting, e.LastImageDownload })
                    .HasName("RealtimeUpdates_GetMissingImages_MostRecentListings");

                entity.HasIndex(e => new { e.ListingId, e.City, e.ListPrice, e.Mlnumber, e.DateAdded, e.Status, e.RentalListing, e.IdSettings, e.HasImage, e.Bedrooms, e.FullBaths })
                    .HasName("missing_index_696526_696525_Listings");

                entity.HasIndex(e => new { e.Sysid, e.ImageCount, e.Mlnumber, e.LastImgTransDate, e.LastImageDownload, e.LastTransDate, e.PropertyImageUrl, e.ImageDownloadAttempts, e.PartialImageDownload, e.IdSettings, e.IdRetsSetting })
                    .HasName("missing_index_99613_99612");

                entity.HasIndex(e => new { e.City, e.CountyName, e.ListPrice, e.Mlnumber, e.SubType, e.SubdivisionName, e.Longitude, e.Latitude, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.LonRad, e.LatRad, e.RentalListing, e.State })
                    .HasName("Idx_Cache_AreaStats_Compute");

                entity.HasIndex(e => new { e.City, e.CountyName, e.SubType, e.SubdivisionName, e.Longitude, e.Latitude, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.LonRad, e.LatRad, e.RentalListing, e.State, e.IdSettings, e.ListPrice })
                    .HasName("Get_Frontend_SurroundingAreaStats_Index");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.ZipCode, e.Longitude, e.Latitude, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.OriginalSubdivisionName, e.IdSettings })
                    .HasName("GetDistinctCitiesFromSearch");

                entity.HasIndex(e => new { e.ListingId, e.Sysid, e.Address, e.Bedrooms, e.FullBaths, e.GarageNum, e.Hoaamount, e.HoafeePer, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.ZipCode, e.Longitude, e.Latitude, e.ShortSaleYn, e.SubType, e.City, e.ListPrice })
                    .HasName("SubTypeCityListPrice");

                entity.HasIndex(e => new { e.State, e.CountyName, e.ZipCode, e.Address, e.Mlnumber, e.ListPrice, e.LastImageDownload, e.DateAdded, e.Latitude, e.Longitude, e.Status, e.SubType, e.PropertyType, e.ForeclosureYn, e.ShortSaleYn, e.IdSettings, e.City, e.SubdivisionName, e.RentalListing })
                    .HasName("SeoCityHoodIndex");

                entity.HasIndex(e => new { e.Sysid, e.Address, e.Bedrooms, e.State, e.FullBaths, e.GarageNum, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.SubdivisionName, e.ZipCode, e.Longitude, e.Latitude, e.ShortSaleYn, e.ForeclosureYn, e.SubType, e.City })
                    .HasName("SubTypeAndCity");

                entity.HasIndex(e => new { e.Bedrooms, e.FullBaths, e.ListPrice, e.City, e.State, e.LivAreaSqFt, e.SubType, e.SubdivisionName, e.ShortSaleYn, e.ForeclosureYn, e.ListingId, e.Sysid, e.Mlnumber, e.ZipCode, e.ListOfficeName, e.Pool, e.WaterfrontYn, e.Address, e.PropertyType, e.Parking, e.LonRad, e.LatRad, e.HasGuardedGate, e.DateDeleted, e.Longitude, e.Latitude })
                    .HasName("GetRecordsCount01");

                entity.HasIndex(e => new { e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.FullBaths, e.GarageNum, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.PublicRemarks, e.SubType, e.SubdivisionName, e.ZipCode, e.Longitude, e.Latitude, e.ListOfficeName, e.LastImageDownload, e.ListAgentId, e.ListOfficePhone, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.IdSettings })
                    .HasName("missing_index_85514_85513");

                entity.HasIndex(e => new { e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.FullBaths, e.GarageNum, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.PublicRemarks, e.SubType, e.SubdivisionName, e.ZipCode, e.Longitude, e.Latitude, e.ListOfficeName, e.LastImageDownload, e.ListOfficePhone, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.IdSettings, e.ListAgentId })
                    .HasName("missing_index_85516_85515");

                entity.HasIndex(e => new { e.ListingId, e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.FullBaths, e.HalfBaths, e.ListPrice, e.LivAreaSqFt, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.ListOfficeName, e.LastImageDownload, e.PropertyType, e.ListOfficePhone, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.RentalListing, e.IdRetsSetting, e.HasPool, e.ThreeQuarterBaths, e.Mlnumber, e.IdSettings })
                    .HasName("idx_idSettings_MLNumber_plus");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.OriginalSubdivisionName, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.HasBasement, e.RetirementCommunity, e.GatedCommunity, e.HasPool, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.FirePlace, e.TotalGarageSpaces, e.HasWoodFloors, e.StreetName, e.HasGuardedGate, e.RentalListing, e.IdSettings })
                    .HasName("RecordsCountIndex");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.ListOfficeId, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.RentalListing, e.OriginalSubdivisionName, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.StreetName, e.HasGuardedGate, e.ThreeQuarterBaths, e.IdSettings })
                    .HasName("missing_index_100569_100568");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.LastTransDate, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.OriginalSubdivisionName, e.HasImage, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.HasBasement, e.RetirementCommunity, e.GatedCommunity, e.HasPool, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.FirePlace, e.HasWoodFloors, e.StreetName, e.TotalGarageSpaces, e.HasGuardedGate, e.IdRetsSetting, e.IdSettings, e.DateAdded })
                    .HasName("GetRecordsPaged02");

                entity.HasIndex(e => new { e.ListingId, e.Bedrooms, e.City, e.CountyName, e.FullBaths, e.Hoaamount, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Status, e.SubType, e.SubdivisionName, e.YearBuilt, e.ZipCode, e.Longitude, e.Latitude, e.ListAgentId, e.ListOfficeId, e.LastTransDate, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.DateAdded, e.RentalListing, e.OriginalSubdivisionName, e.HasImage, e.LotSizeSqFt, e.SchoolElemId, e.SchoolMidId, e.SchoolHighId, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.StreetName, e.HasGuardedGate, e.ThreeQuarterBaths, e.IdSettings })
                    .HasName("idx_idSettings_plus");

                entity.HasIndex(e => new { e.ListingId, e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.CountyName, e.FullBaths, e.GarageNum, e.HalfBaths, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionName, e.WaterfrontYn, e.WaterfrontDesc, e.YearBuilt, e.ZipCode, e.ListOfficeName, e.IsNew, e.LastImgTransDate, e.PropertyType, e.ListAgentId, e.ListOfficeId, e.LastTransDate, e.LotDescription, e.Parking, e.Design, e.Roof, e.ListOfficePhone, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.IdSettings, e.LotSizeSqFt, e.IdRetsSetting, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.HasGuardedGate, e.IdRetsClass })
                    .HasName("missing_index_85418_85417");

                entity.HasIndex(e => new { e.ListingId, e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.CountyName, e.FullBaths, e.GarageNum, e.HalfBaths, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionName, e.WaterfrontYn, e.WaterfrontDesc, e.YearBuilt, e.ZipCode, e.ListOfficeName, e.IsNew, e.LastImgTransDate, e.PropertyType, e.ListAgentId, e.ListOfficeId, e.LastTransDate, e.LotDescription, e.Parking, e.Design, e.Roof, e.ListOfficePhone, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.IdSettings, e.PropertyImageUrl, e.LotSizeSqFt, e.IdRetsSetting, e.AttachedType, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.HasGuardedGate, e.IdRetsClass })
                    .HasName("missing_index_144772_144771");

                entity.HasIndex(e => new { e.ListingId, e.Sysid, e.Address, e.Bedrooms, e.City, e.State, e.CountyName, e.FullBaths, e.GarageNum, e.HalfBaths, e.Hoaamount, e.HoafeePer, e.ListPrice, e.LivAreaSqFt, e.Mlnumber, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionName, e.WaterfrontYn, e.WaterfrontDesc, e.YearBuilt, e.ZipCode, e.ListOfficeName, e.IsNew, e.LastImgTransDate, e.PropertyType, e.ListAgentId, e.ListOfficeId, e.MinimumDaysLease, e.LastTransDate, e.LotDescription, e.Parking, e.Design, e.Roof, e.SpecialInformation, e.ListOfficePhone, e.GeoArea, e.ShortSaleYn, e.ForeclosureYn, e.RentalListing, e.IdSettings, e.PropertyImageUrl, e.LotSizeSqFt, e.IdRetsSetting, e.SchoolElem, e.SchoolHigh, e.AttachedType, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.HasGuardedGate, e.IdRetsClass })
                    .HasName("ix_Listings_idRetsClass_includes");

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.ForeclosureYn).HasDefaultValueSql("0");

                entity.Property(e => e.FullBaths).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasImage).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsClass).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.ImageCount).HasDefaultValueSql("0");

                entity.Property(e => e.ImageDownloadAttempts).HasDefaultValueSql("0");

                entity.Property(e => e.Indexed).HasDefaultValueSql("1");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.LatRad).HasDefaultValueSql("0");

                entity.Property(e => e.Latitude).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LonRad).HasDefaultValueSql("0");

                entity.Property(e => e.Longitude).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.MasterOnMain).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.PartialImageDownload).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ListingsSold>(entity =>
            {
                entity.HasKey(e => e.ListingSoldId)
                    .HasName("PK_ListingsSold_ListingSoldID");

                entity.HasIndex(e => new { e.ImageCount, e.LastImgTransDate, e.LastImageDownload, e.ImageDownloadAttempts, e.PartialImageDownload, e.IdSettings })
                    .HasName("Suggested_Index_Images");

                entity.HasIndex(e => new { e.Sysid, e.ImageCount, e.Mlnumber, e.LastImgTransDate, e.LastImageDownload, e.LastTransDate, e.PropertyImageUrl, e.ImageDownloadAttempts, e.PartialImageDownload, e.IdSettings, e.IdRetsSetting })
                    .HasName("idx_comp1a");

                entity.HasIndex(e => new { e.ListingSoldId, e.ListAgentId, e.ListOfficeId, e.BuyerAgentId, e.Address, e.City, e.State, e.ZipCode, e.Mlnumber, e.ListPrice, e.Bedrooms, e.FullBaths, e.LivAreaSqFt, e.LastImageDownload, e.IdSettings, e.SoldDate })
                    .HasName("ListingsSold_AgentDetailPage");

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.ForeclosureYn).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasImage).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsClass).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.ImageCount).HasDefaultValueSql("0");

                entity.Property(e => e.ImageDownloadAttempts).HasDefaultValueSql("0");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.LatRad).HasDefaultValueSql("0");

                entity.Property(e => e.Latitude).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LonRad).HasDefaultValueSql("0");

                entity.Property(e => e.Longitude).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.PartialImageDownload).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasDefaultValueSql("'FL'");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ListingsSoldTemp>(entity =>
            {
                entity.HasKey(e => e.ListingId)
                    .HasName("PK_ListingsSoldTemp_2");

                entity.Property(e => e.Address1).HasDefaultValueSql("0");

                entity.Property(e => e.Address2).HasDefaultValueSql("0");

                entity.Property(e => e.Address3).HasDefaultValueSql("0");

                entity.Property(e => e.Address4).HasDefaultValueSql("0");

                entity.Property(e => e.Address5).HasDefaultValueSql("0");

                entity.Property(e => e.Address6).HasDefaultValueSql("0");

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsClass).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone1).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone2).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone3).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone4).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone1).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone2).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone3).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone4).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ListingsTemp>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.Mlnumber })
                    .HasName("idx_idSettings_MLNumber");

                entity.HasIndex(e => new { e.Mlnumber, e.IdRetsClass })
                    .HasName("idx_MLNumber_idRetsClass");

                entity.HasIndex(e => new { e.ListingId, e.CountyName, e.IdSettings })
                    .HasName("NormalizationHelp");

                entity.HasIndex(e => new { e.ListingId, e.IdRetsClass, e.IdRetsSetting })
                    .HasName("RealtimeUpdates_idRetsClass");

                entity.HasIndex(e => new { e.ListingId, e.SubType, e.IdSettings })
                    .HasName("NormalizationHelp2");

                entity.HasIndex(e => new { e.ListingId, e.SubType, e.Design, e.IdRetsSetting })
                    .HasName("missing_index_82849_82848");

                entity.HasIndex(e => new { e.ListingId, e.IdRetsSetting, e.IdRetsClass, e.DateAdded, e.IdSettings, e.DateTimeOffsetAdded })
                    .HasName("RETS_DateAddedOffset_Cleanup");

                entity.HasIndex(e => new { e.Sysid, e.Addenda, e.Address, e.Bedrooms, e.City, e.State, e.Construction, e.CountyName, e.DevelopmentName, e.Equipment, e.ExteriorFeature, e.Flooring, e.FullBaths, e.Furnished, e.GarageNum, e.GoverningBody, e.HalfBaths, e.Hoa, e.Hoaamount, e.HoafeePer, e.InteriorFeature, e.ListPrice, e.LivAreaSqFt, e.MaintenanceFeeIncludes, e.Mlnumber, e.OriginalListPrice, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionInfo, e.SubdivisionName, e.TaxAmount, e.TaxYear, e.Taxes, e.TotalBldgSfincl, e.PropertyView, e.VirtualTourLink, e.WaterfrontYn, e.WaterfrontDesc, e.YearBuilt, e.ZipCode, e.Zoning, e.ListAgentName, e.ListAgentPhone, e.IsVisible, e.ListOfficeName, e.LastUpdate, e.LastImgTransDate, e.PropertyType, e.InternetDisplay, e.ParcelId, e.ListAgentId, e.ZipPlus4, e.ApplicationFee, e.BalconyLength, e.BalconyWidth, e.BuildingNum, e.Bedrm2Length, e.Bedrm2Width, e.Bedrm3Lendth, e.Bedrm3Width, e.Bedrm4Length, e.Bedrm4Width, e.Bedrm5Length, e.Bedrm5Width, e.CarportNum, e.DiningAreaLength, e.DiningAreaWidth, e.DenLength, e.DenWidth, e.DiningRmLength, e.DiningRmWidth, e.FamilyRmWidth, e.FamilyRmLength, e.FloridaRmLength, e.FloridaRmWidth, e.FrontExposure, e.GuestHouseSqft, e.KitchenLength, e.KitchenWidth, e.ListOfficeId, e.LivingRmLength, e.LivingRmWidth, e.LotSize, e.LeaseTimesperYr, e.MasterBdrmLength, e.MasterBdrmWidth, e.MembershipEquity, e.MinimumDaysLease, e.ModelName, e.PetsAllowed, e.PoolLength, e.PoolWidth, e.LastTransDate, e.TermsOfSale, e.SpecialAssessment, e.TotalUnitsinBldg, e.TotalUnitsinComplex, e.UnitFloorNumber, e.WaterFrontageinfeet, e.BoatService, e.Cooling, e.Heating, e.LotDescription, e.Membership, e.Parking, e.PrivatePoolDescription, e.Restrictions, e.Design, e.DiningArea, e.GuestHouse, e.MobileHmFeatures, e.MasterBdrmBath, e.Roof, e.Rooms, e.WindowTreatment, e.Security, e.SpecialInformation, e.UnitDescriptions, e.Utilities, e.ListAgentEmail, e.ListOfficePhone, e.TotalFloors, e.GeoArea, e.RegionalIdmlx, e.MarketCode, e.ShortSaleYn, e.ForeclosureYn, e.AllowAddressDisplay, e.AllowValue, e.AllowComments, e.DateAdded, e.RentalListing, e.IdSettings, e.PropertyImageUrl, e.LotSizeSqFt, e.SchoolElem, e.SchoolMid, e.SchoolHigh, e.AttachedType, e.FirePlace, e.HasBasement, e.HasPool, e.TotalGarageSpaces, e.GatedCommunity, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.IdRetsClass, e.RentalIncomeAnnual, e.LivAreaSqFtSource, e.RentalCompany, e.RentalNumber, e.RentalName, e.Directions, e.Foundation, e.Extras, e.HasGuardedGate, e.ListingAgentStateLicenseNumber, e.CoListingAgentName, e.CoListingAgentOfficeName, e.CoListingAgentStateLicenseNumber, e.IdRetsSetting })
                    .HasName("RealtimeUpdate_UpdateFromListingsTemp_idRetsSettings");

                entity.HasIndex(e => new { e.Sysid, e.Addenda, e.Address, e.Bedrooms, e.City, e.State, e.Construction, e.CountyName, e.DevelopmentName, e.Equipment, e.ExteriorFeature, e.Flooring, e.FullBaths, e.Furnished, e.GarageNum, e.GoverningBody, e.HalfBaths, e.Hoa, e.Hoaamount, e.HoafeePer, e.InteriorFeature, e.ListPrice, e.LivAreaSqFt, e.MaintenanceFeeIncludes, e.Mlnumber, e.OriginalListPrice, e.Pool, e.PublicRemarks, e.Status, e.SubType, e.SubdivisionInfo, e.SubdivisionName, e.TaxAmount, e.TaxYear, e.Taxes, e.TotalBldgSfincl, e.PropertyView, e.VirtualTourLink, e.WaterfrontYn, e.WaterfrontDesc, e.YearBuilt, e.ZipCode, e.Zoning, e.ListAgentName, e.ListAgentPhone, e.IsVisible, e.ListOfficeName, e.LastUpdate, e.LastImgTransDate, e.PropertyType, e.InternetDisplay, e.ParcelId, e.ListAgentId, e.ZipPlus4, e.ApplicationFee, e.BalconyLength, e.BalconyWidth, e.BuildingNum, e.Bedrm2Length, e.Bedrm2Width, e.Bedrm3Lendth, e.Bedrm3Width, e.Bedrm4Length, e.Bedrm4Width, e.Bedrm5Length, e.Bedrm5Width, e.CarportNum, e.DiningAreaLength, e.DiningAreaWidth, e.DenLength, e.DenWidth, e.DiningRmLength, e.DiningRmWidth, e.FamilyRmWidth, e.FamilyRmLength, e.FloridaRmLength, e.FloridaRmWidth, e.FrontExposure, e.GuestHouseSqft, e.KitchenLength, e.KitchenWidth, e.ListOfficeId, e.LivingRmLength, e.LivingRmWidth, e.LotSize, e.LeaseTimesperYr, e.MasterBdrmLength, e.MasterBdrmWidth, e.MembershipEquity, e.MinimumDaysLease, e.ModelName, e.PetsAllowed, e.PoolLength, e.PoolWidth, e.LastTransDate, e.TermsOfSale, e.SpecialAssessment, e.TotalUnitsinBldg, e.TotalUnitsinComplex, e.UnitFloorNumber, e.WaterFrontageinfeet, e.BoatService, e.Cooling, e.Heating, e.LotDescription, e.Membership, e.Parking, e.PrivatePoolDescription, e.Restrictions, e.Design, e.DiningArea, e.GuestHouse, e.MobileHmFeatures, e.MasterBdrmBath, e.Roof, e.Rooms, e.WindowTreatment, e.Security, e.SpecialInformation, e.UnitDescriptions, e.Utilities, e.ListAgentEmail, e.ListOfficePhone, e.TotalFloors, e.GeoArea, e.RegionalIdmlx, e.MarketCode, e.ShortSaleYn, e.ForeclosureYn, e.AllowAddressDisplay, e.AllowValue, e.AllowComments, e.RentalListing, e.IdSettings, e.PropertyImageUrl, e.AwcRemarks, e.LivAreaSqFt2, e.LotSizeSqFt, e.IdRetsSetting, e.Amenities, e.SchoolElem, e.SchoolMid, e.SchoolHigh, e.AttachedType, e.FirePlace, e.HasBasement, e.HasPool, e.RetirementCommunity, e.TotalGarageSpaces, e.GatedCommunity, e.NoHoa, e.WalkInCloset, e.IsWaterfront, e.IsReo, e.PetsAllowedBit, e.IsCbs, e.HasWoodFloors, e.RentalIncomeAnnual, e.LivAreaSqFtSource, e.RentalCompany, e.RentalNumber, e.RentalName, e.Directions, e.Foundation, e.Extras, e.HasGuardedGate, e.ListPriceLow, e.ListPriceHigh, e.BasementDetails, e.ContingentChangeDate, e.Exterior, e.Fuel, e.KitchenAmenities, e.Misc, e.PersPropIncluded, e.PropertySubjectTo, e.RealPropExcluded, e.Sewer, e.Road, e.TypeOfContract, e.ListingAgentStateLicenseNumber, e.CoListingAgentName, e.CoListingAgentOfficeName, e.CoListingAgentStateLicenseNumber, e.IdRetsClass })
                    .HasName("missing_index_82668_82667");

                entity.Property(e => e.Address1).HasDefaultValueSql("0");

                entity.Property(e => e.Address2).HasDefaultValueSql("0");

                entity.Property(e => e.Address3).HasDefaultValueSql("0");

                entity.Property(e => e.Address4).HasDefaultValueSql("0");

                entity.Property(e => e.Address5).HasDefaultValueSql("0");

                entity.Property(e => e.Address6).HasDefaultValueSql("0");

                entity.Property(e => e.AwcRemarks).HasDefaultValueSql("0");

                entity.Property(e => e.FirePlace).HasDefaultValueSql("0");

                entity.Property(e => e.ForeclosureYn).HasDefaultValueSql("0");

                entity.Property(e => e.FullBaths).HasDefaultValueSql("0");

                entity.Property(e => e.GatedCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.HasBasement).HasDefaultValueSql("0");

                entity.Property(e => e.HasGuardedGate).HasDefaultValueSql("0");

                entity.Property(e => e.HasPool).HasDefaultValueSql("0");

                entity.Property(e => e.HasWoodFloors).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsClass).HasDefaultValueSql("0");

                entity.Property(e => e.IdRetsSetting).HasDefaultValueSql("0");

                entity.Property(e => e.ImageCount).HasDefaultValueSql("0");

                entity.Property(e => e.IsCbs).HasDefaultValueSql("0");

                entity.Property(e => e.IsReo).HasDefaultValueSql("0");

                entity.Property(e => e.IsWaterfront).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone1).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone2).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone3).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentPhone4).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone1).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone2).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone3).HasDefaultValueSql("0");

                entity.Property(e => e.ListOfficePhone4).HasDefaultValueSql("0");

                entity.Property(e => e.LivAreaSqFt2).HasDefaultValueSql("0");

                entity.Property(e => e.LotSizeSqFt).HasDefaultValueSql("0");

                entity.Property(e => e.MasterOnMain).HasDefaultValueSql("0");

                entity.Property(e => e.NoHoa).HasDefaultValueSql("0");

                entity.Property(e => e.RentalListing).HasDefaultValueSql("0");

                entity.Property(e => e.RetirementCommunity).HasDefaultValueSql("0");

                entity.Property(e => e.ThreeQuarterBaths).HasDefaultValueSql("0");

                entity.Property(e => e.TotalGarageSpaces).HasDefaultValueSql("0");

                entity.Property(e => e.WalkInCloset).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ListingsTemp1>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK__Listings__9ED730F9D1A7F645");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => new { e.Event, e.Detail })
                    .HasName("LogIndex");

                entity.HasIndex(e => new { e.Detail, e.UniqueId, e.IdSettings })
                    .HasName("ix_Log_UniqueID_idSettings_includes");

                entity.HasIndex(e => new { e.UniqueId, e.Detail, e.Event })
                    .HasName("ix_Log_Event_includes");

                entity.HasIndex(e => new { e.UniqueId, e.Detail, e.IdSettings })
                    .HasName("idUser_idSettings_Detail_Lookup");

                entity.HasIndex(e => new { e.Detail, e.Created, e.UniqueId, e.Event })
                    .HasName("LeadDetailSearchHistory");

                entity.HasIndex(e => new { e.Detail, e.UniqueId, e.Event, e.IdSettings })
                    .HasName("Log_SuggestedIndex");

                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.PageViewed).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LogPartialLead>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.PageViewed).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mandrill>(entity =>
            {
                entity.HasIndex(e => e.IdDripCampaign)
                    .HasName("idx_idDripCampaign");

                entity.HasIndex(e => e.IdMassEmail)
                    .HasName("idx_idMassEmail");

                entity.HasIndex(e => e.IdSettings)
                    .HasName("idx_idSettings");

                entity.HasIndex(e => e.MessageId)
                    .HasName("MessageIDIndex");

                entity.HasIndex(e => new { e.IdMassEmail, e.MandrillClick })
                    .HasName("IX_mandrill_mandrillclick");

                entity.HasIndex(e => new { e.MandrillOpen, e.IdDripCampaign })
                    .HasName("missing_index_99173_99172");

                entity.HasIndex(e => new { e.MandrillSend, e.IdDripCampaign })
                    .HasName("missing_index_84013_84012");

                entity.HasIndex(e => new { e.MandrillSend, e.IdMassEmail })
                    .HasName("missing_index_2698_2697_Mandrill");

                entity.HasIndex(e => new { e.LeadEmail, e.MandrillOpen, e.MandrillClick })
                    .HasName("LeadEmailIndex");

                entity.HasIndex(e => new { e.IdLead, e.MandrillClick, e.MandrillOpen, e.LeadEmail })
                    .HasName("GetLeadsPaged_Click_Open");

                entity.HasIndex(e => new { e.IdMandrill, e.MandrillClick, e.MandrillOpen, e.IdLead })
                    .HasName("Mandrill_LeadDashboardUpdateIndex");

                entity.HasIndex(e => new { e.IdMassEmail, e.MandrillClick, e.MandrillBounce, e.MandrillUnSub, e.MandrillSend, e.MandrillSpam, e.IdSettings, e.IdLead, e.IdDripCampaign, e.IdDripCampaignEventTemplate, e.MandrillOpen })
                    .HasName("MandrillOpenIndex");

                entity.HasIndex(e => new { e.IdMandrill, e.MandrillBounce, e.MandrillClick, e.MandrillUnSub, e.MandrillSend, e.MandrillSpam, e.DateSent, e.EmailSubject, e.MessageId, e.LeadEmail, e.FromEmail, e.IdSettings, e.SerializedEmail, e.IdLead, e.IdDripCampaign, e.IdDripCampaignEventTemplate, e.IdAgentSentFrom, e.UploadedToAzureBlob, e.IdMassEmail, e.MandrillOpen })
                    .HasName("idx_");

                entity.Property(e => e.MandrillBounce).HasDefaultValueSql("0");

                entity.Property(e => e.MandrillClick).HasDefaultValueSql("0");

                entity.Property(e => e.MandrillOpen).HasDefaultValueSql("0");

                entity.Property(e => e.MandrillSend).HasDefaultValueSql("0");

                entity.Property(e => e.MandrillSpam).HasDefaultValueSql("0");

                entity.Property(e => e.MandrillUnSub).HasDefaultValueSql("0");

                entity.Property(e => e.UploadedToAzureBlob).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MapCustomArea>(entity =>
            {
                entity.Property(e => e.IsLandingPage).HasDefaultValueSql("0");

                entity.Property(e => e.IsSavedSearch).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MapCustomAreaDetails>(entity =>
            {
                entity.HasIndex(e => new { e.Longitude, e.Latitude, e.OrderNumber, e.IdMapCustomArea })
                    .HasName("MapCustomAreaDetails_GetSpecificMapArea");
            });

            modelBuilder.Entity<MassEmail>(entity =>
            {
                entity.HasIndex(e => new { e.EmailsOpened, e.IdMassEmail })
                    .HasName("idx_EmailsOpened");

                entity.Property(e => e.ActualSendTimeStamp).HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.EmailsBounced).HasDefaultValueSql("0");

                entity.Property(e => e.EmailsClicked).HasDefaultValueSql("0");

                entity.Property(e => e.EmailsOpened).HasDefaultValueSql("0");

                entity.Property(e => e.EmailsSent).HasDefaultValueSql("0");

                entity.Property(e => e.Sent).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.OrderNum).HasDefaultValueSql("9999");
            });

            modelBuilder.Entity<MlsareaAutoComplete>(entity =>
            {
                entity.HasIndex(e => new { e.IdMlsareaAutoComplete, e.GeoAreaShort, e.IdSettings })
                    .HasName("MLSAreaShort");
            });

            modelBuilder.Entity<MlsautoComplete>(entity =>
            {
                entity.HasIndex(e => e.ListingId)
                    .HasName("missing_index_2624_2623");

                entity.HasIndex(e => new { e.IdSettings, e.ListingId })
                    .HasName("RealtimeUpdates");

                entity.HasIndex(e => new { e.IdMlsautoComplete, e.IdSettings, e.MlnumberShort })
                    .HasName("missing_index_11860_11859");

                entity.HasIndex(e => new { e.IdMlsautoComplete, e.MlnumberShort, e.IdSettings })
                    .HasName("MLNumberShort");
            });

            modelBuilder.Entity<MobileDeviceTokens>(entity =>
            {
                entity.HasKey(e => e.IdMobileDeviceToken)
                    .HasName("PK__MobileDe__1B30D44514EA934A");

                entity.Property(e => e.Created).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUsed).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<NestedMenus>(entity =>
            {
                entity.HasIndex(e => e.IdSettings)
                    .HasName("NestedMenus_SiteSetup");

                entity.HasIndex(e => new { e.IdNestedMenu, e.Lft, e.Rgt })
                    .HasName("missing_index_20_19");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => new { e.IdNotification, e.NoticeRead, e.NotificationText, e.EmailSent, e.NoticeComplete, e.NotificationType, e.IdLead, e.NotificationTimeStamp })
                    .HasName("missing_index_10579_10578");

                entity.Property(e => e.EmailSent).HasDefaultValueSql("0");

                entity.Property(e => e.NoticeComplete).HasDefaultValueSql("0");

                entity.Property(e => e.NoticeRead).HasDefaultValueSql("0");

                entity.Property(e => e.NotificationType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PartialLeads>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.CreatedDate })
                    .HasName("CreatedTimeIdSettings");

                entity.Property(e => e.Condition).HasDefaultValueSql("0");

                entity.Property(e => e.Converted).HasDefaultValueSql("0");

                entity.Property(e => e.IdAgent).HasDefaultValueSql("0");

                entity.Property(e => e.LeadType).HasDefaultValueSql("0");

                entity.Property(e => e.TimeFrame).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PhoneBucket>(entity =>
            {
                entity.HasIndex(e => new { e.IdAgent, e.PhoneBucketTitle })
                    .HasName("UC_PhoneBucketTitle")
                    .IsUnique();

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.ManualBucket).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<RenderedHtml>(entity =>
            {
                entity.HasIndex(e => new { e.TimeStampRendered, e.Mlnumber, e.IdSettings, e.IdRenderedHtml })
                    .HasName("ExcludingRenderedHTML");
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.Property(e => e.Latitude).HasDefaultValueSql("0");

                entity.Property(e => e.Longitude).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ResultTableWork>(entity =>
            {
                entity.HasIndex(e => e.Bedrooms)
                    .HasName("idx_Bedrooms");

                entity.HasIndex(e => e.City)
                    .HasName("idx_City");

                entity.HasIndex(e => e.DeletedBath)
                    .HasName("idx_DeletedBath");

                entity.HasIndex(e => e.DeletedBedroom)
                    .HasName("idx_DeletedBedroom");

                entity.HasIndex(e => e.DeletedCity)
                    .HasName("idx_DeletedCity");

                entity.HasIndex(e => e.DeletedHood)
                    .HasName("idx_DeletedHood");

                entity.HasIndex(e => e.DeletedPrice)
                    .HasName("idx_DeletedPrice");

                entity.HasIndex(e => e.DeletedThreeBath)
                    .HasName("idx_DeletedThreeBath");

                entity.HasIndex(e => e.DeletedType)
                    .HasName("idx_DeletedType");

                entity.HasIndex(e => e.FullBaths)
                    .HasName("idx_FullBaths");

                entity.HasIndex(e => e.ListPrice)
                    .HasName("idx_listprice");

                entity.HasIndex(e => e.ThreeQuarterBaths)
                    .HasName("idx_ThreeQuarterBaths");

                entity.HasIndex(e => new { e.IdSettings, e.ThreeQuarterBaths, e.City, e.SubdivisionName, e.Subtype, e.DeletedIdsettings, e.DeletedPrice, e.DeletedBath, e.DeletedThreeBath, e.DeletedBedroom, e.DeletedCity, e.DeletedHood, e.DeletedType, e.IdLead, e.ListPrice, e.FullBaths, e.Bedrooms })
                    .HasName("idx_comp1a");
            });

            modelBuilder.Entity<RetsClasses>(entity =>
            {
                entity.HasIndex(e => e.IdRetsSetting)
                    .HasName("missing_index_1965_1964");

                entity.HasIndex(e => new { e.IdRetsClass, e.IdRetsSetting })
                    .HasName("missing_index_1963_1962");

                entity.Property(e => e.ClassType).HasDefaultValueSql("0");

                entity.Property(e => e.Import).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RetsFields>(entity =>
            {
                entity.HasIndex(e => new { e.DbfieldMapping, e.IdSettings, e.SetType })
                    .HasName("missing_index_28_27");

                entity.HasIndex(e => new { e.DbfieldMapping, e.CheckForBooleanTypes, e.IdSettings, e.IdRetsClass })
                    .HasName("missing_index_126833_126832");

                entity.HasIndex(e => new { e.IdRetsField, e.Name, e.MaxLength, e.Sample, e.DbfieldMapping, e.SetType, e.Required, e.CheckForBooleanTypes, e.IdRetsClass, e.IdSettings, e.FieldDescription })
                    .HasName("Realtime_Update_Index");

                entity.Property(e => e.Required).HasDefaultValueSql("0");

                entity.Property(e => e.SetType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RetsFieldsTemp>(entity =>
            {
                entity.Property(e => e.Required).HasDefaultValueSql("0");

                entity.Property(e => e.SetType).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RetsSettings>(entity =>
            {
                entity.Property(e => e.AllowSoldData).HasDefaultValueSql("0");

                entity.Property(e => e.FeedType).HasDefaultValueSql("0");

                entity.Property(e => e.FtpfeedType).HasDefaultValueSql("0");

                entity.Property(e => e.IsAgentListedAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.IsDetailPageAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.ManualFullUpdate).HasDefaultValueSql("0");

                entity.Property(e => e.MlscomplianceAgeRestriction).HasDefaultValueSql("0");

                entity.Property(e => e.MlscomplianceImageRestriction).HasDefaultValueSql("0");

                entity.Property(e => e.MlsimageType).HasDefaultValueSql("0");

                entity.Property(e => e.PullLimit).HasDefaultValueSql("2500");

                entity.Property(e => e.ShowAboveFoldListOfficeName).HasDefaultValueSql("0");

                entity.Property(e => e.ShowBrokerOnSearchResults).HasDefaultValueSql("0");

                entity.Property(e => e.SkipRemove).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<SchoolAutoSearch>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.SchoolNameShort })
                    .HasName("IndexSchoolShort");

                entity.HasIndex(e => new { e.SchoolName, e.Id, e.SchoolType, e.IdSettings })
                    .HasName("SchoolAutoSearchIndex");
            });

            modelBuilder.Entity<Schools>(entity =>
            {
                entity.HasIndex(e => e.SchoolId)
                    .HasName("missing_index_3050_3049_Schools");

                entity.HasIndex(e => e.Zip)
                    .HasName("Rets_NightlyUpdate_Zip");

                entity.HasIndex(e => new { e.TestRatingText, e.City, e.State })
                    .HasName("CityState");

                entity.Property(e => e.Aypresult).HasDefaultValueSql("0");

                entity.Property(e => e.DataSourceType).HasDefaultValueSql("1");

                entity.Property(e => e.Enrollment).HasDefaultValueSql("0");

                entity.Property(e => e.LatRad).HasDefaultValueSql("0");

                entity.Property(e => e.Latitude).HasDefaultValueSql("0");

                entity.Property(e => e.LonRad).HasDefaultValueSql("0");

                entity.Property(e => e.Longitude).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Scrollers>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.ScrollerGroupName })
                    .HasName("Suggested_idSettingsIndex");

                entity.Property(e => e.CustomSlider).HasDefaultValueSql("0");

                entity.Property(e => e.ImageHeight).HasDefaultValueSql("0");

                entity.Property(e => e.ImageWidth).HasDefaultValueSql("0");

                entity.Property(e => e.IsActive).HasDefaultValueSql("0");

                entity.Property(e => e.OrderNum).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SeoDetails>(entity =>
            {
                entity.HasIndex(e => new { e.City, e.Neighborhood })
                    .HasName("Neighborhood");

                entity.Property(e => e.State).HasDefaultValueSql("'FL'");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.IdSettings)
                    .HasName("PK_TempSettings");

                entity.Property(e => e.AboveFoldListOfficeName).HasDefaultValueSql("0");

                entity.Property(e => e.AgentVisibility).HasDefaultValueSql("0");

                entity.Property(e => e.AllowAgentCustomAutoSavedSearchEmail).HasDefaultValueSql("1");

                entity.Property(e => e.AllowAgentCustomFeaturedProperties).HasDefaultValueSql("1");

                entity.Property(e => e.AllowAgentTargetAreaUpdates).HasDefaultValueSql("1");

                entity.Property(e => e.AllowAgentTransfers).HasDefaultValueSql("0");

                entity.Property(e => e.AllowAgentsToCreateBlogs).HasDefaultValueSql("0");

                entity.Property(e => e.AllowAgentsToDeleteLeads).HasDefaultValueSql("0");

                entity.Property(e => e.AllowAutoGeneratedSearches).HasDefaultValueSql("0");

                entity.Property(e => e.AllowCommunityDrips).HasDefaultValueSql("1");

                entity.Property(e => e.AutomaticHiddenLeads).HasDefaultValueSql("0");

                entity.Property(e => e.BackendPageViews).HasDefaultValueSql("0");

                entity.Property(e => e.ConductRetsCleanup).HasDefaultValueSql("0");

                entity.Property(e => e.CustomAutoSavedSearchBody).HasDefaultValueSql("''");

                entity.Property(e => e.CustomAutoSavedSearchSubject).HasDefaultValueSql("''");

                entity.Property(e => e.CustomCssupdated).HasDefaultValueSql("getdate()");

                entity.Property(e => e.DaylightSavings).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultPageHideSearchControl).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultPageHideSearchControl1).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultSearchFrequency).HasDefaultValueSql("0");

                entity.Property(e => e.EngLendingOn).HasDefaultValueSql("0");

                entity.Property(e => e.ForceRegIn).HasDefaultValueSql("2");

                entity.Property(e => e.FrontPagePriceMinimum).HasDefaultValueSql("0");

                entity.Property(e => e.FrontPageRentMinimum).HasDefaultValueSql("0");

                entity.Property(e => e.HeaderPhoneShown).HasDefaultValueSql("0");

                entity.Property(e => e.HideImagesIn).HasDefaultValueSql("0");

                entity.Property(e => e.HideSqFtOnSearchResults).HasDefaultValueSql("0");

                entity.Property(e => e.IdxFeedType).HasDefaultValueSql("0");

                entity.Property(e => e.InFullUpdate).HasDefaultValueSql("0");

                entity.Property(e => e.InRealtimeUpdate).HasDefaultValueSql("0");

                entity.Property(e => e.IsActive).HasDefaultValueSql("0");

                entity.Property(e => e.IsCanadianMls).HasDefaultValueSql("0");

                entity.Property(e => e.IsPorchOn).HasDefaultValueSql("0");

                entity.Property(e => e.LastRealtimeUpdate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.LeadExpireSeconds).HasDefaultValueSql("0");

                entity.Property(e => e.ListAgentLeadPriority).HasDefaultValueSql("1");

                entity.Property(e => e.ListingSearchType).HasDefaultValueSql("1");

                entity.Property(e => e.LotSizesMapped).HasDefaultValueSql("0");

                entity.Property(e => e.MarketBudget).HasDefaultValueSql("0");

                entity.Property(e => e.MlsDisclaimerOnSearchResults).HasDefaultValueSql("0");

                entity.Property(e => e.MortgagePercent).HasDefaultValueSql("5");

                entity.Property(e => e.PriceTier).HasDefaultValueSql("0");

                entity.Property(e => e.RealTimeSeo).HasDefaultValueSql("0");

                entity.Property(e => e.RealtimeUpdateFrequencyInMilliSeconds).HasDefaultValueSql("900000");

                entity.Property(e => e.SearchResultsPaged).HasDefaultValueSql("0");

                entity.Property(e => e.SendAcceptLeadEmail).HasDefaultValueSql("1");

                entity.Property(e => e.SendAutomaticReminderEmail).HasDefaultValueSql("1");

                entity.Property(e => e.SendEmailMethod).HasDefaultValueSql("0");

                entity.Property(e => e.SendEmailVerification).HasDefaultValueSql("1");

                entity.Property(e => e.SendSavedSearchTime).HasDefaultValueSql("'1/1/1970 08:00:00 -05:00'");

                entity.Property(e => e.SendThirdPartyWelcomeEmail).HasDefaultValueSql("1");

                entity.Property(e => e.ShowAgentLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowBlogLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowBrokerOnSearchResults).HasDefaultValueSql("0");

                entity.Property(e => e.ShowBuyLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowCareersLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowFinanceOption).HasDefaultValueSql("0");

                entity.Property(e => e.ShowFrontPageHomes).HasDefaultValueSql("1");

                entity.Property(e => e.ShowFrontPageRentals).HasDefaultValueSql("0");

                entity.Property(e => e.ShowHeaderPhone).HasDefaultValueSql("0");

                entity.Property(e => e.ShowListAgentExceptCname).HasDefaultValueSql("1");

                entity.Property(e => e.ShowListingNoAddress).HasDefaultValueSql("0");

                entity.Property(e => e.ShowLocationsLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowLotSizeInAcres).HasDefaultValueSql("0");

                entity.Property(e => e.ShowMlsLogoOnAllListings).HasDefaultValueSql("0");

                entity.Property(e => e.ShowPreferredAgentListOnForcedReg).HasDefaultValueSql("1");

                entity.Property(e => e.ShowRegPopupOn).HasDefaultValueSql("0");

                entity.Property(e => e.ShowRentals).HasDefaultValueSql("1");

                entity.Property(e => e.ShowRentalsOnSeo).HasDefaultValueSql("1");

                entity.Property(e => e.ShowReviews).HasDefaultValueSql("0");

                entity.Property(e => e.ShowSellLink).HasDefaultValueSql("1");

                entity.Property(e => e.ShowSoldLink).HasDefaultValueSql("0");

                entity.Property(e => e.ShowVirtualLink).HasDefaultValueSql("0");

                entity.Property(e => e.Smsdefault).HasDefaultValueSql("2000");

                entity.Property(e => e.SslEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.ThirdPartyLeadsUseDripTriggers).HasDefaultValueSql("0");

                entity.Property(e => e.UseCustomEmailTemplate).HasDefaultValueSql("0");

                entity.Property(e => e.UseCustomMainPageScrollerHtml).HasDefaultValueSql("0");

                entity.Property(e => e.UseMlsdc).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SettingsOld>(entity =>
            {
                entity.HasKey(e => e.IdSettings)
                    .HasName("PK_Settings");
            });

            modelBuilder.Entity<SmsCluster>(entity =>
            {
                entity.HasKey(e => e.IdSmsCluster)
                    .HasName("PK__SMS_Clus__8C76BD167A6B862A");
            });

            modelBuilder.Entity<SmsClusterAudit>(entity =>
            {
                entity.HasKey(e => e.IdSmsClusterAudit)
                    .HasName("PK__SMS_Clus__38421C1E7E3C170E");

                entity.HasIndex(e => e.IdSmsmessage)
                    .HasName("missing_index_27111_27110");

                entity.HasIndex(e => new { e.IdSmsmessage, e.IdSettings })
                    .HasName("missing_index_11973_11972");

                entity.HasIndex(e => new { e.IdSmsmessageType, e.IdSmsmessage })
                    .HasName("missing_index_27109_27108");
            });

            modelBuilder.Entity<SmsFlag>(entity =>
            {
                entity.HasKey(e => e.IdSmsFlag)
                    .HasName("PK__SMS_Flag__5FFA46700300CC2B");

                entity.HasIndex(e => e.SmsFlag1)
                    .HasName("UC_SMS_Flag")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Smsmessage>(entity =>
            {
                entity.HasKey(e => e.IdSmsmessage)
                    .HasName("PK__SMSMessa__7931509B08B9A581");

                entity.HasIndex(e => new { e.FromPhone, e.IdSmsmessageType, e.IdSmsFlag })
                    .HasName("missing_index_1610_1609");

                entity.HasIndex(e => new { e.FromPhone, e.IdMassSms, e.IdSmsmessageType, e.IdSmsFlag })
                    .HasName("missing_index_99665_99664");
            });

            modelBuilder.Entity<SmsmessageAudit>(entity =>
            {
                entity.HasKey(e => e.IdSmsmessageAudit)
                    .HasName("PK__SMSMessa__554E40FF0C8A3665");

                entity.HasIndex(e => e.IdLead)
                    .HasName("missing_index_667_666");

                entity.HasIndex(e => e.IdSmsmessage)
                    .HasName("UC_SMSMessageAudit")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateTimeReceived, e.Processed })
                    .HasName("missing_index_27091_27090");

                entity.HasIndex(e => new { e.IdLead, e.Processed })
                    .HasName("missing_index_27095_27094");

                entity.HasIndex(e => new { e.ToPhone, e.DateTimeToAudit })
                    .HasName("Date_ToPhone_Index");

                entity.HasIndex(e => new { e.IdSettings, e.Processed, e.IsPaid })
                    .HasName("missing_index_149_148");

                entity.HasIndex(e => new { e.IdSmsmessage, e.DateTimeReceived, e.Processed, e.IsPaid })
                    .HasName("missing_index_151_150");
            });

            modelBuilder.Entity<SmsmessageType>(entity =>
            {
                entity.HasKey(e => e.IdSmsmessageType)
                    .HasName("PK__SMSMessa__DBEA41EF114EEB82");

                entity.HasIndex(e => e.SmsmessageType1)
                    .HasName("UC_SMSMessageType")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Squeeze>(entity =>
            {
                entity.Property(e => e.EmailCuriousSellers).HasDefaultValueSql("0");

                entity.Property(e => e.EmailFirstStep).HasDefaultValueSql("0");

                entity.Property(e => e.FinalPage).HasDefaultValueSql("'summary'");

                entity.Property(e => e.FooterSqueezePage).HasDefaultValueSql("0");

                entity.Property(e => e.GatherContactDetails).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneFirstStep).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneRequired).HasDefaultValueSql("0");

                entity.Property(e => e.UseCloudCmaifAvailable).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Ssl>(entity =>
            {
                entity.HasKey(e => e.IdSsl)
                    .HasName("PK__Ssl__024E755A7B2E965A");

                entity.Property(e => e.SslEnabled).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<StreetNameAutoComplete>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_StreetNameAutoComplete_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();

                entity.Property(e => e.IdStreetNameAutoComplete).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StreetNameAutoComplete1>(entity =>
            {
                entity.HasIndex(e => new { e.IdSettings, e.StreetName })
                    .HasName("missing_index_97_96");

                entity.HasIndex(e => new { e.StreetName, e.IdSettings })
                    .HasName("missing_index_130_129_StreetNameAutoComplete");

                entity.HasIndex(e => new { e.IdStreetNameAutoComplete, e.First5, e.IdSettings })
                    .HasName("idSettingsIndex");
            });

            modelBuilder.Entity<TaskMessage>(entity =>
            {
                entity.HasKey(e => e.IdTaskMessage)
                    .HasName("PK__TaskMess__79C253F21707C4D8");
            });

            modelBuilder.Entity<TorchxGl>(entity =>
            {
                entity.HasKey(e => e.TorchxGid)
                    .HasName("PK_TorchxGL_TorchxGID");

                entity.Property(e => e.TorchxGid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TownCenter>(entity =>
            {
                entity.Property(e => e.Views).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserSavedProperties>(entity =>
            {
                entity.HasIndex(e => new { e.IdUsers, e.IsTrash })
                    .HasName("idx_idUsers_isTrash");

                entity.Property(e => e.IdUserSavedProperties).HasDefaultValueSql("newid()");

                entity.Property(e => e.IsTrash).HasDefaultValueSql("0");

                entity.Property(e => e.Saved).HasDefaultValueSql("getdate()");

                entity.Property(e => e.SentByAgent).HasDefaultValueSql("0");

                entity.Property(e => e.Viewed).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<UserSavedSearches>(entity =>
            {
                entity.HasKey(e => e.IdUserSavedSearches)
                    .HasName("PK_Users_1");

                entity.HasIndex(e => new { e.IdUsers, e.IdSettings, e.AutoGenerated })
                    .HasName("GetLeadsPaged");

                entity.HasIndex(e => new { e.IdUserSavedSearches, e.IdUsers, e.QueryString, e.Name, e.LastEmailUpdate, e.SentByAgent, e.Frequency, e.AutoGenerated, e.LastProcessed, e.SendUpdates, e.IdSettings })
                    .HasName("missing_index_27657_27656");

                entity.HasIndex(e => new { e.IdUserSavedSearches, e.IdUsers, e.QueryString, e.Name, e.SentByAgent, e.IdSettings, e.Frequency, e.AutoGenerated, e.LastProcessed, e.SendUpdates, e.LastEmailUpdate })
                    .HasName("LastProcessed");

                entity.Property(e => e.IdUserSavedSearches).HasDefaultValueSql("newid()");

                entity.Property(e => e.AutoGenerated).HasDefaultValueSql("0");

                entity.Property(e => e.Frequency).HasDefaultValueSql("0");

                entity.Property(e => e.IdUsers).HasDefaultValueSql("newid()");

                entity.Property(e => e.LastEmailUpdate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Saved).HasDefaultValueSql("getdate()");

                entity.Property(e => e.SendUpdates).HasDefaultValueSql("1");

                entity.Property(e => e.Viewed).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<UserTracking>(entity =>
            {
                entity.HasIndex(e => e.SessionId)
                    .HasName("SessionIdIndex");

                entity.Property(e => e.ClickImageReg).HasDefaultValueSql("0");

                entity.Property(e => e.ClickSubmit).HasDefaultValueSql("0");

                entity.Property(e => e.ClickedFacebook).HasDefaultValueSql("0");

                entity.Property(e => e.EventDate).HasDefaultValueSql("datediff(second,'1970-01-01 00:00:00.000',getdate())");

                entity.Property(e => e.FbregClick).HasDefaultValueSql("0");

                entity.Property(e => e.FbregSuccess).HasDefaultValueSql("0");

                entity.Property(e => e.FieldChanged).HasDefaultValueSql("0");

                entity.Property(e => e.GoodRegAttempt).HasDefaultValueSql("0");

                entity.Property(e => e.LeftPage).HasDefaultValueSql("0");

                entity.Property(e => e.RequestedListingPage).HasDefaultValueSql("0");

                entity.Property(e => e.SawForcedReg).HasDefaultValueSql("0");

                entity.Property(e => e.SawImageReg).HasDefaultValueSql("0");

                entity.Property(e => e.SawListingPage).HasDefaultValueSql("0");
            });
        }
    }
}