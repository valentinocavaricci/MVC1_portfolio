using Microsoft.AspNetCore.Mvc;

namespace MVC1_portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
