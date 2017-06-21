using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class MapCustomAreaDetails
    {
        [Column("idMapCustomAreaDetails")]
        [Key]
        public int IdMapCustomAreaDetails { get; set; }
        [Column("idMapCustomArea")]
        public int IdMapCustomArea { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int OrderNumber { get; set; }
    }
}
