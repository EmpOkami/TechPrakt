using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechPrakt.Models
{
    [PrimaryKey(nameof(ArtifactId), nameof(CategoryId))]
    public class ArtifactCategories
    {
        public int ArtifactId { get; set; }
        public int CategoryId { get; set; }

    }
}
