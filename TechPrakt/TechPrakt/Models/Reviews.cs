using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace TechPrakt.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
