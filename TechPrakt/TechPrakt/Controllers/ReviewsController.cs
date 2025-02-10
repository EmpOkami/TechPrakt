using Microsoft.AspNetCore.Mvc;
using TechPrakt.Models;
using Microsoft.EntityFrameworkCore;

public class ReviewsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReviewsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var reviews = await _context.Reviews.OrderByDescending(r => r.CreatedAt).ToListAsync();
        return View(reviews);
    }

    public IActionResult Create()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            TempData["ErrorMessage"] = "Щоб залишити відгук, потрібно увійти в систему.";
            return RedirectToAction("Index");
        }

        return View(new Reviews());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Reviews review)
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        var userName = HttpContext.Session.GetString("UserName");

        if (userId == null || string.IsNullOrEmpty(userName))
        {
            TempData["ErrorMessage"] = "Щоб залишити відгук, потрібно увійти в систему.";
            return RedirectToAction("Index");
        }

        review.UserId = userId.Value;
        review.Name = userName;
        review.CreatedAt = DateTime.Now;

        if (ModelState.IsValid)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Відгук успішно додано!";
            return RedirectToAction("Index");
        }

        return View(review);
    }
}
