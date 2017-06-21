using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class MapCustomArea
    {
        [Column("idMapCustomArea")]
        [Key]
        public int IdMapCustomArea { get; set; }
        public double TopLat { get; set; }
        public double BottomLat { get; set; }
        public double LeftLng { get; set; }
        public double RightLng { get; set; }
        public bool IsSavedSearch { get; set; }
        public bool IsLandingPage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastRebuild { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
    }
}
