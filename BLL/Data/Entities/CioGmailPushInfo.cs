using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CIO_GmailPushInfo", Schema = "CIO")]
    public partial class CioGmailPushInfo
    {
        [Column("idCIO_GmailPushInfo")]
        public int IdCioGmailPushInfo { get; set; }
        [MaxLength(300)]
        public string Token { get; set; }
        [MaxLength(300)]
        public string RefreshToken { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? GoodUntil { get; set; }
        [Column(TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? WatchGoodUntil { get; set; }
        public long? HistoryProcessedUntil { get; set; }
    }
}
