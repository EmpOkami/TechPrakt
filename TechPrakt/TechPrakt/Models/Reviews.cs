using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace TechPrakt.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ArtifactId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
