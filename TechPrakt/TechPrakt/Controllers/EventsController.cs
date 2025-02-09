using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TechPrakt.Models;

namespace TechPrakt.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Exhibitions.ToListAsync();
            return View(events);
        }

        public async Task<IActionResult> Details(int id)
        {
            var exhibition = await _context.Exhibitions
                .FirstOrDefaultAsync(e => e.Id == id);

            if (exhibition == null)
            {
                return NotFound();
            }

            return View(exhibition);
        }

        [HttpPost]
        public async Task<IActionResult> BuyTicket(int exhibitionId)
        {
            var exhibition = await _context.Exhibitions.FindAsync(exhibitionId);
            if (exhibition == null)
            {
                return NotFound();
            }

            var ticket = new Tickets
            {
                ExhibitionId = exhibitionId,
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = exhibitionId });
        }
    }
}
