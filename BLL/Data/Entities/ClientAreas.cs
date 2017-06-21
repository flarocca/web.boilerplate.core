using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    [Table("ClientAreas", Schema = "MLSDatacenter")]
    public partial class ClientAreas
    {
        [Column("AreaID")]
        public int AreaId { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [MaxLength(100)]
        public string County { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Area { get; set; }
        public bool Selected { get; set; }
    }
}
