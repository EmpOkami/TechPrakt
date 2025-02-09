using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TechPrakt.Models;

namespace TechPrakt.Controllers
{
    public class ArtifactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtifactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var artifacts = await _context.Artifacts.ToListAsync();
            return View(artifacts);
        }

        public async Task<IActionResult> Details(int id)
        {
            var artifact = await _context.Artifacts.FindAsync(id);

            if (artifact == null)
            {
                return NotFound();
            }

            return View(artifact);
        }
    }
}
