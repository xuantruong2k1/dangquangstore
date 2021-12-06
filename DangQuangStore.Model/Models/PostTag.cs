using DangQuangStore.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("PostTags")]
    public class PostTag : Auditable
    {
        [Key]
        
        public int PostID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}