using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace TechPrakt.Models
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        public int ExhibitionId { get; set; }
        public string TicketType { get; set; }
        public decimal price { get; set; }
    }
}
