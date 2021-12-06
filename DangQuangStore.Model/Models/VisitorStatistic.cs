﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
   
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        
        [MaxLength(50)]
        public string IpAddress { get; set; }
    }
}