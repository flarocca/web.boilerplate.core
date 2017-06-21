using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class RetsSettings
    {
        [Column("idRetsSetting")]
        [Key]
        public int IdRetsSetting { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [Column("RetsURL")]
        [MaxLength(255)]
        public string RetsUrl { get; set; }
        [Required]
        [MaxLength(50)]
        public string RetsLogin { get; set; }
        [Required]
        [MaxLength(50)]
        public string RetsPassword { get; set; }
        [MaxLength(50)]
        public string RetsUserAgentLogin { get; set; }
        [MaxLength(50)]
        public string RetsUserAgentPassword { get; set; }
        [MaxLength(50)]
        public string SelectedResource { get; set; }
        [MaxLength(200)]
        public string RetsVersion { get; set; }
        [MaxLength(50)]
        public string RetsPhotoObject { get; set; }
        [MaxLength(50)]
        public string RetsUserAgent { get; set; }
        public bool SkipRemove { get; set; }
        [Column("MLSImageType")]
        public byte MlsimageType { get; set; }
        public string NormalizationScript { get; set; }
        public int FeedType { get; set; }
        [Column("FTPFeedType")]
        public int FtpfeedType { get; set; }
        [Column("FTPTableTypes")]
        [MaxLength(50)]
        public string FtptableTypes { get; set; }
        public int? ServerTimeOffsetHours { get; set; }
        [MaxLength(30)]
        public string SpecialDateFormat { get; set; }
        [MaxLength(200)]
        public string AboveFoldListOfficeName { get; set; }
        [MaxLength(300)]
        public string CustomBrokerSearchResults { get; set; }
        [Column("MLSCopywriteText")]
        public string MlscopywriteText { get; set; }
        [MaxLength(200)]
        public string CustomListingPageDisclaimer { get; set; }
        [Column("MLSLogoUrl")]
        [MaxLength(200)]
        public string MlslogoUrl { get; set; }
        public bool ShowAboveFoldListOfficeName { get; set; }
        public bool ShowBrokerOnSearchResults { get; set; }
        public bool AllowSoldData { get; set; }
        [Column("MLSCompliance_AgeRestriction")]
        public byte MlscomplianceAgeRestriction { get; set; }
        [Column("MLSCompliance_ImageRestriction")]
        public byte MlscomplianceImageRestriction { get; set; }
        public byte IsDetailPageAllowed { get; set; }
        [Column("NWMLSQuery", TypeName = "varchar(800)")]
        public string Nwmlsquery { get; set; }
        public int PullLimit { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string AuthorizedServers { get; set; }
        public bool IsAgentListedAllowed { get; set; }
        public bool ManualFullUpdate { get; set; }
    }
}
