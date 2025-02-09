using Microsoft.EntityFrameworkCore;

namespace TechPrakt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Exhibitions> Exhibitions { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Artifacts> Artifacts { get; set; }
        public DbSet<ArtifactExhibition> ArtifactExhibitions { get; set; }
        public DbSet<ArtifactCategories> ArtifactCategories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
