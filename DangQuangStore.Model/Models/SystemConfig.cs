﻿using DangQuangStore.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig : Auditable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }
        [MaxLength(50)]
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
    }
}