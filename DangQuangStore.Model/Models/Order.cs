using DangQuangStore.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DangQuangStore.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomAddres { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomMessage { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}