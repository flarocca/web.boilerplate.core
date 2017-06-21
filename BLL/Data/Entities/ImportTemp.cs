using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class ImportTemp
    {
        [Column("idLead")]
        public int IdLead { get; set; }
        [Column("idUser")]
        public Guid? IdUser { get; set; }
        [Column("idAgent")]
        public int? IdAgent { get; set; }
        [MaxLength(50)]
        public string AcceptKey { get; set; }
        public int? PreviousAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateActivity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateExpire { get; set; }
        [MaxLength(50)]
        public string UserPassword { get; set; }
        [MaxLength(50)]
        public string Telephone1 { get; set; }
        [MaxLength(50)]
        public string Telephone2 { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string Referral { get; set; }
        [MaxLength(255)]
        public string LandingPage { get; set; }
        [MaxLength(255)]
        public string LeadDetail { get; set; }
        [MaxLength(50)]
        public string LeadDetailType { get; set; }
        public short? Status { get; set; }
        [MaxLength(100)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(75)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(5)]
        public string Zip { get; set; }
        [Column(TypeName = "money")]
        public decimal? AveragePrice { get; set; }
        public int? ListingsViewed { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public bool? NeedUser { get; set; }
        public bool? CreateLead { get; set; }
    }
}
