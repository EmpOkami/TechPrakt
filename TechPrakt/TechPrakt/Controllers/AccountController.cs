using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TechPrakt.Models;
namespace TechPrakt.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            return RedirectToAction("Index", "Home");
        }
    }
}
