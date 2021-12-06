using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("Pages")]
    internal class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Content { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}