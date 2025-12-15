using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;

namespace MVC1_portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactViewModel());
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            ViewData["Success"] = true;

            return View(new ContactViewModel());
        }
    }
}
