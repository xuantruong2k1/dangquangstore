﻿using DangQuangStore.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("PostCategorys")]
    internal class PostCategory : Auditable

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        public string MoreImage { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}