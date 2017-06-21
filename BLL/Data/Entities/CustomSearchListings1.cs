using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("CustomSearch_Listings", Schema = "MLSDatacenter")]
    public partial class CustomSearchListings1
    {
        [Column("idCustomSearch_Listings")]
        public long IdCustomSearchListings { get; set; }
        [Column("TorchxGID")]
        public long TorchxGid { get; set; }
        [Column("MLSLookupID")]
        public int MlslookupId { get; set; }
        [Column("idCustomSearch_FieldValue")]
        public int IdCustomSearchFieldValue { get; set; }
        [Column("idCustomSearch_FieldType")]
        public byte IdCustomSearchFieldType { get; set; }
    }
}
