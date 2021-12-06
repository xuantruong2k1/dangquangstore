using DangQuangStore.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("Tags")]
    public class Tag : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int ID { set; get; }
        [MaxLength(50)]
        [Required]
        public string Name { set; get; }
        [MaxLength(50)]
        [Required]
        public string Type { set; get; }
}
}