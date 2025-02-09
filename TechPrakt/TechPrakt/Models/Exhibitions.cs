using System.ComponentModel.DataAnnotations;

namespace TechPrakt.Models
{
    public class Exhibitions
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
