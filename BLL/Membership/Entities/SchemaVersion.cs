using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Membership
{
    [Table("aspnet_SchemaVersions")]
    public partial class SchemaVersion
    {
		public bool IsCurrentVersion { get; set; }

		[MaxLength(128)]
        public string Feature { get; set; }

        [MaxLength(128)]
        public string CompatibleSchemaVersion { get; set; }
    }
}
