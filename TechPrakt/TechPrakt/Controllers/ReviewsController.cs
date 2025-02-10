using Microsoft.AspNetCore.Mvc;
using TechPrakt.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace TechPrakt.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var reviews = _context.Reviews.OrderByDescending(r => r.CreatedAt).ToList();
            return View(reviews);
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["ErrorMessage"] = "Вам потрібно увійти в систему, щоб залишити відгук.";
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reviews review)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                TempData["ErrorMessage"] = "Вам потрібно увійти в систему, щоб залишити відгук.";
                return RedirectToAction("Login", "Account");
            }

            if (ModelState.IsValid)
            {
                review.UserId = HttpContext.Session.GetInt32("UserId").Value;
                review.CreatedAt = DateTime.Now;
                _context.Reviews.Add(review);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Ваш відгук успішно додано!";
                return RedirectToAction("Index");
            }

            return View(review);
        }
    }
}
