using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class UserTracking
    {
        [Column("idUserTracking")]
        [Key]
        public int IdUserTracking { get; set; }
        [Column("SessionID")]
        [MaxLength(28)]
        public string SessionId { get; set; }
        public bool SawListingPage { get; set; }
        public bool SawForcedReg { get; set; }
        public bool FieldChanged { get; set; }
        public bool ClickSubmit { get; set; }
        public bool ClickedFacebook { get; set; }
        public bool RequestedListingPage { get; set; }
        [MaxLength(300)]
        public string UserAgent { get; set; }
        public bool LeftPage { get; set; }
        public bool GoodRegAttempt { get; set; }
        public int? EventDate { get; set; }
        [Column("RequestedURL")]
        [MaxLength(255)]
        public string RequestedUrl { get; set; }
        [MaxLength(20)]
        public string ScreenRes { get; set; }
        public bool SawImageReg { get; set; }
        public bool ClickImageReg { get; set; }
        public string FieldsSubmitted { get; set; }
        [Column("idSettings")]
        public int? IdSettings { get; set; }
        [Column("FBRegSuccess")]
        public bool FbregSuccess { get; set; }
        [Column("FBRegClick")]
        public bool FbregClick { get; set; }
    }
}
