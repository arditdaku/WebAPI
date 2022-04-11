using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CardOwnerName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; } = string.Empty;
    }
}
