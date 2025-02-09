using System.ComponentModel.DataAnnotations;

namespace TechPrakt.Models
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
