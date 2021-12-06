using DangQuangStore.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Department { get; set; }
        public string Skype { get; set; }
        [MaxLength(50)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Facebook { get; set; }
        [Required]
        public bool Status { get; set; }
        
    }
}