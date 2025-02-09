using System.ComponentModel.DataAnnotations;

namespace TechPrakt.Models
{
    public class Artifacts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Image {  get; set; }
    }
}
