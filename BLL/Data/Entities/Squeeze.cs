using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class Squeeze
    {
        [Column("idSqueeze")]
        [Key]
        public int IdSqueeze { get; set; }
        [Required]
        [MaxLength(250)]
        public string BackgroundImage { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string WebTitle { get; set; }
        [Column("Email_CuriousSellers")]
        public bool EmailCuriousSellers { get; set; }
        [Column("Email_FirstStep")]
        public bool EmailFirstStep { get; set; }
        public bool GatherContactDetails { get; set; }
        [Column("UseCloudCMAIfAvailable")]
        public bool UseCloudCmaifAvailable { get; set; }
        public bool FooterSqueezePage { get; set; }
        [Column("Phone_FirstStep")]
        public bool PhoneFirstStep { get; set; }
        [Column("Phone_Required")]
        public bool PhoneRequired { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string FinalPage { get; set; }
    }
}
