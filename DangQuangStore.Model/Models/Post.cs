using DangQuangStore.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }
        [Required]
        
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [Required]
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Waranty { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryId")]
        public virtual PostCategory PostCategory { set; get; }
    }
}