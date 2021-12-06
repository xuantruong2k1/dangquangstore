using DangQuangStore.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag : Auditable
    
    {
        [Key]
        
        public int ProductId { set; get; }
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}