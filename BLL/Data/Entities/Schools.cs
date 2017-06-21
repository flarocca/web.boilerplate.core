using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Schools
    {
        [Column("idSchool")]
        [Key]
        public int IdSchool { get; set; }
        [Column("address")]
        [MaxLength(200)]
        public string Address { get; set; }
        [Column("AYPresult")]
        public bool Aypresult { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [Column("DistrictID")]
        public int? DistrictId { get; set; }
        public int? DistrictLeAid { get; set; }
        public int Enrollment { get; set; }
        [MaxLength(30)]
        public string GradesServed { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Column("NCESid")]
        [MaxLength(25)]
        public string Ncesid { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(150)]
        public string SchoolDistrictName { get; set; }
        [Column("SchoolID")]
        public int? SchoolId { get; set; }
        [MaxLength(100)]
        public string SchoolName { get; set; }
        [MaxLength(50)]
        public string SchoolType { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        public int? StudentTeacherRatio { get; set; }
        [MaxLength(150)]
        public string TestRatingImageLarge { get; set; }
        [MaxLength(150)]
        public string TestRatingImageSmall { get; set; }
        [MaxLength(50)]
        public string TestRatingText { get; set; }
        [Column("URL")]
        [MaxLength(200)]
        public string Url { get; set; }
        [MaxLength(200)]
        public string Website { get; set; }
        [Column(TypeName = "varchar(11)")]
        public string Zip { get; set; }
        [Column("latRad")]
        public double LatRad { get; set; }
        [Column("lonRad")]
        public double LonRad { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        public byte DataSourceType { get; set; }
    }
}
