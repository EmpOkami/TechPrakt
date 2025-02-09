using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TechPrakt.Models
{
    [PrimaryKey(nameof(ArtifactId), nameof(ExhibitionId))]
    public class ArtifactExhibition
    {
        public int ArtifactId { get; set; }
        public int ExhibitionId { get; set; }
    }
}
