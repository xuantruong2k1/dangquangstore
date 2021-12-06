using DangQuangStore.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("ProductCategories")]
    internal class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
    }
}