﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.TORCHx.Core.BLL.Data
{
    public partial class RetsFieldsTemp
    {
        [Column("idRetsField")]
        [Key]
        public int IdRetsField { get; set; }
        [Column("idRetsClass")]
        public int IdRetsClass { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string FieldDescription { get; set; }
        public int MaxLength { get; set; }
        public string Sample { get; set; }
        [Column("DBFieldMapping")]
        [MaxLength(30)]
        public string DbfieldMapping { get; set; }
        [Column("idSettings")]
        public int IdSettings { get; set; }
        public byte SetType { get; set; }
        public bool Required { get; set; }
    }
}
