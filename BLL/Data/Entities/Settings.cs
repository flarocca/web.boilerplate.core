using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Settings
    {
        public Settings()
        {
            Ssl = new HashSet<Ssl>();
        }

        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Column("URL", TypeName = "varchar(100)")]
        public string Url { get; set; }
        [Column("dbView", TypeName = "varchar(50)")]
        public string DbView { get; set; }
        public string BuyersText { get; set; }
        public string SellersText { get; set; }
        [MaxLength(150)]
        public string DefaultPageTitle { get; set; }
        [MaxLength(500)]
        public string MainFeaturedCity { get; set; }
        public string DefaultPageBottomLeftBlerb { get; set; }
        public string DefaultPageRightBlerb { get; set; }
        public string FeaturedCityList { get; set; }
        public bool? ShowBuyLink { get; set; }
        public bool? ShowSellLink { get; set; }
        public bool? ShowBlogLink { get; set; }
        public bool? ShowAgentLink { get; set; }
        public bool? ShowLocationsLink { get; set; }
        public bool? ShowCareersLink { get; set; }
        [MaxLength(150)]
        public string FinanceAgent { get; set; }
        public bool? ShowFinanceOption { get; set; }
        [MaxLength(150)]
        public string FinanceEmail { get; set; }
        public int? MortgagePercent { get; set; }
        [Column("FbAppID")]
        [MaxLength(50)]
        public string FbAppId { get; set; }
        public bool? ShowFrontPageRentals { get; set; }
        public bool? ShowFrontPageHomes { get; set; }
        [Column("MLSCopywriteText")]
        public string MlscopywriteText { get; set; }
        public bool? SendAcceptLeadEmail { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string FooterText { get; set; }
        public string AgentPageText { get; set; }
        public bool ShowHeaderPhone { get; set; }
        [MaxLength(50)]
        public string HeaderPhoneNumber { get; set; }
        [MaxLength(150)]
        public string OfficeName { get; set; }
        [MaxLength(150)]
        public string OfficeAddress { get; set; }
        [MaxLength(100)]
        public string OfficeAddress2 { get; set; }
        [MaxLength(100)]
        public string OfficeAddress3 { get; set; }
        [MaxLength(250)]
        public string OfficeContactBlock { get; set; }
        [Column("OfficeLogoURL")]
        [MaxLength(150)]
        public string OfficeLogoUrl { get; set; }
        [MaxLength(150)]
        public string OfficeLogoLink { get; set; }
        public string DefaultPageBottomMiddleBlerb { get; set; }
        public string DefaultPageBottomRightBlerb { get; set; }
        [MaxLength(500)]
        public string HeaderPhone { get; set; }
        [Column("ShowRentalsOnSEO")]
        public bool ShowRentalsOnSeo { get; set; }
        [Column("BlogURL")]
        [MaxLength(255)]
        public string BlogUrl { get; set; }
        [Column("MLSLogoURL")]
        [MaxLength(200)]
        public string MlslogoUrl { get; set; }
        public bool AllowAgentTransfers { get; set; }
        public string AnalyticsCode { get; set; }
        public int FrontPagePriceMinimum { get; set; }
        [Column("CustomCSS")]
        public string CustomCss { get; set; }
        [MaxLength(150)]
        public string HeaderImage { get; set; }
        [MaxLength(150)]
        public string FooterImage { get; set; }
        [Column("GoogleMapsAPI")]
        [MaxLength(200)]
        public string GoogleMapsApi { get; set; }
        public string WelcomeEmailText { get; set; }
        public bool ShowRentals { get; set; }
        [MaxLength(100)]
        public string ContextIoId { get; set; }
        public int ForceRegIn { get; set; }
        public int ShowRegPopupOn { get; set; }
        [MaxLength(200)]
        public string BuyersImage { get; set; }
        [MaxLength(200)]
        public string SellersImage { get; set; }
        [MaxLength(255)]
        public string MobileLogo { get; set; }
        public bool UseCustomEmailTemplate { get; set; }
        public string CustomEmailTemplate { get; set; }
        public int HideImagesIn { get; set; }
        [MaxLength(100)]
        public string BingVerification { get; set; }
        [MaxLength(100)]
        public string FavIcon { get; set; }
        public byte AgentVisibility { get; set; }
        public bool HeaderPhoneShown { get; set; }
        public bool ShowListAgentExceptCname { get; set; }
        [MaxLength(50)]
        public string SiteTwitterHandle { get; set; }
        [Column("CraigsListURL")]
        [MaxLength(150)]
        public string CraigsListUrl { get; set; }
        [MaxLength(150)]
        public string MobileHeaderImage { get; set; }
        public int? IndexSalePriceMin { get; set; }
        public int? IndexRentPriceMin { get; set; }
        [MaxLength(75)]
        public string HomeWelcomeHeadline { get; set; }
        public string HomeWelcomeBody { get; set; }
        [MaxLength(30)]
        public string HomeWelcomeButtonText { get; set; }
        [MaxLength(125)]
        public string HomeWelcomeButtonLink { get; set; }
        [MaxLength(125)]
        public string HomeWelcomeImage { get; set; }
        public bool ShowBrokerOnSearchResults { get; set; }
        public int BackendPageViews { get; set; }
        public string BuyersMoreInformation { get; set; }
        public string SellersMoreInformation { get; set; }
        public int LeadExpireSeconds { get; set; }
        public bool AllowAgentTargetAreaUpdates { get; set; }
        [MaxLength(100)]
        public string TypeKitCode { get; set; }
        [Column("ImageDIR")]
        [MaxLength(50)]
        public string ImageDir { get; set; }
        [Column("PlacesterAPIKey")]
        [MaxLength(100)]
        public string PlacesterApikey { get; set; }
        public int FrontPageRentMinimum { get; set; }
        public string ManualLeadWelcomeEmailText { get; set; }
        public bool ListAgentLeadPriority { get; set; }
        public string FrontPageSaleFilter { get; set; }
        public string FrontPageRentFilter { get; set; }
        [MaxLength(100)]
        public string CustomEmailLogo { get; set; }
        public bool LotSizesMapped { get; set; }
        [MaxLength(125)]
        public string GoogleBusinessPage { get; set; }
        public bool ShowPreferredAgentListOnForcedReg { get; set; }
        public string DefaultCityPageText { get; set; }
        public string DefaultHoodPageText { get; set; }
        [MaxLength(100)]
        public string DefaultCityPageTitle { get; set; }
        [MaxLength(100)]
        public string DefaultHoodPageTitle { get; set; }
        [MaxLength(400)]
        public string VerifyEmailText { get; set; }
        [MaxLength(15)]
        public string TwilioNumber { get; set; }
        public bool AboveFoldListOfficeName { get; set; }
        public bool DaylightSavings { get; set; }
        [MaxLength(32)]
        public string LocalTimeZone { get; set; }
        public bool ShowMlsLogoOnAllListings { get; set; }
        [MaxLength(300)]
        public string CustomBrokerSearchResultsText { get; set; }
        public bool AllowAgentsToCreateBlogs { get; set; }
        public bool MlsDisclaimerOnSearchResults { get; set; }
        public bool SearchResultsPaged { get; set; }
        public string SearchPageMlsText { get; set; }
        public bool AllowAutoGeneratedSearches { get; set; }
        [MaxLength(200)]
        public string AboveFoldListOfficeNameText { get; set; }
        [MaxLength(200)]
        public string CustomListingPageDisclaimer { get; set; }
        public string CodeOnReg { get; set; }
        public string ThirdPartyLeadImportText { get; set; }
        public bool SendThirdPartyWelcomeEmail { get; set; }
        public bool EngLendingOn { get; set; }
        public bool ShowVirtualLink { get; set; }
        [MaxLength(75)]
        public string ScheduleOnceCode { get; set; }
        [Column("CloudCMAApiKey")]
        [MaxLength(75)]
        public string CloudCmaapiKey { get; set; }
        [Column("BuyerInitialSMSTemplate")]
        [MaxLength(160)]
        public string BuyerInitialSmstemplate { get; set; }
        [Column("SellerInitialSMSTemplate")]
        [MaxLength(160)]
        public string SellerInitialSmstemplate { get; set; }
        [Column("ImageGruntDNS")]
        [MaxLength(100)]
        public string ImageGruntDns { get; set; }
        public bool InFullUpdate { get; set; }
        public string CustomizedCmaEmailText { get; set; }
        public bool RealTimeSeo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastRealtimeUpdate { get; set; }
        public int IdxFeedType { get; set; }
        [MaxLength(100)]
        public string AgentPageTitle { get; set; }
        [Column("CustomPageCSS")]
        public string CustomPageCss { get; set; }
        [MaxLength(750)]
        public string MlsFooterDisplay { get; set; }
        public bool HideSqFtOnSearchResults { get; set; }
        [Column("MainPageSellersURL")]
        [MaxLength(150)]
        public string MainPageSellersUrl { get; set; }
        [MaxLength(25)]
        public string CountyLabel { get; set; }
        [MaxLength(75)]
        public string GlobalSecondaryidAgents { get; set; }
        public bool ShowReviews { get; set; }
        public bool AllowCommunityDrips { get; set; }
        [Required]
        [MaxLength(160)]
        public string CustomAutoSavedSearchSubject { get; set; }
        [Required]
        public string CustomAutoSavedSearchBody { get; set; }
        public bool AllowAgentCustomAutoSavedSearchEmail { get; set; }
        public bool ShowListingNoAddress { get; set; }
        [Column("CustomMainPageScrollerHTML")]
        public string CustomMainPageScrollerHtml { get; set; }
        [Column("UseCustomMainPageScrollerHTML")]
        public bool UseCustomMainPageScrollerHtml { get; set; }
        [Column("CustomCSSUpdated", TypeName = "datetime")]
        public DateTime CustomCssupdated { get; set; }
        public string MainPageCustomDescriptionMetaTag { get; set; }
        public byte ListingSearchType { get; set; }
        public bool AllowAgentCustomFeaturedProperties { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string DefaultCustomFeaturedPropetiesQuery { get; set; }
        public bool IsPorchOn { get; set; }
        public bool ShowSoldLink { get; set; }
        [Column("CompanyMlsID", TypeName = "varchar(100)")]
        public string CompanyMlsId { get; set; }
        public bool ShowLotSizeInAcres { get; set; }
        public int? MaxPropertiesPerSearch { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastFullUpdateDateTime { get; set; }
        public int RealtimeUpdateFrequencyInMilliSeconds { get; set; }
        public bool ConductRetsCleanup { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FullUpdateTime { get; set; }
        public bool SendEmailVerification { get; set; }
        public bool AllowAgentsToDeleteLeads { get; set; }
        public bool SendAutomaticReminderEmail { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string AsyncRegCodeScriptTags { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string AsyncRegCodeJavascript { get; set; }
        [Column("SMSDefault")]
        public int Smsdefault { get; set; }
        public bool AutomaticHiddenLeads { get; set; }
        [Column("DefaultPage_HideSearchControl")]
        public bool? DefaultPageHideSearchControl { get; set; }
        public bool InRealtimeUpdate { get; set; }
        [Column("DefaultPageHideSearchControl")]
        public bool DefaultPageHideSearchControl1 { get; set; }
        [Column("SparkFooterCTA", TypeName = "varchar(max)")]
        public string SparkFooterCta { get; set; }
        public bool ThirdPartyLeadsUseDripTriggers { get; set; }
        public byte SendEmailMethod { get; set; }
        public byte DefaultSearchFrequency { get; set; }
        public int? PrimaryContactIdLead { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LiveDate { get; set; }
        public int PriceTier { get; set; }
        public int MarketBudget { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? LastRetsCleanupDateTimeOffset { get; set; }
        public DateTimeOffset SendSavedSearchTime { get; set; }
        [Column("useMLSDC")]
        public bool UseMlsdc { get; set; }
        [Column("YoTrackID", TypeName = "varchar(25)")]
        public string YoTrackId { get; set; }
        [Column("IsCanadianMLS")]
        public bool IsCanadianMls { get; set; }
        [Column("sslEnabled")]
        public bool SslEnabled { get; set; }
        [Column("sslRequestDate", TypeName = "datetime")]
        public DateTime? SslRequestDate { get; set; }
        [Column("sslExpirationDate", TypeName = "datetime")]
        public DateTime? SslExpirationDate { get; set; }
        [Column("sslStatus", TypeName = "varchar(15)")]
        public string SslStatus { get; set; }
        [Column("sslProductId", TypeName = "varchar(15)")]
        public string SslProductId { get; set; }

        [InverseProperty("IdSettingsNavigation")]
        public virtual ICollection<Ssl> Ssl { get; set; }
    }
}
