using System.ComponentModel.DataAnnotations;

namespace TechPrakt.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
    }
}
