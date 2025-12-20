using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using System.Collections.Generic;

namespace MVC1_portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Finance Dashboard",
                    Description = "A server-rendered ASP.NET MVC finance dashboard with transaction CRUD, states, and updating account balance.",
                    TechStack = "ASP.NET MVC, C#, Razor, Bootstrap",
                    Status = "In Progress",
                    Link = "/Dashboard"
                },

                new Project
                {
                    
                    Title = "Contact Form Backend",
                    Description = "An MVC contact form demonstrating model validation, POST handling, and clean separation of concerns.",
                    TechStack = "ASP.NET MVC, C#, Razor",
                    Status = "Complete",
                    Link = "/Contact",
               
                },

                new Project
                {
                    Title = "Secure Authenticated Dashboard",
                    Description = "Planned extension to add authentication and persistence using cloud services.",
                    TechStack = "ASP.NET MVC, AWS (Planned)",
                    Status = "Planned"
                },

                new Project
                {
                    Title = "BRAG — Senior Project: Social Media Application",
                    Description = "A capstone project focused on building a social-style portfolio platform where users can showcase achievements as posts. Designed to demonstrate full-stack abilties, authentication, and backend abilities.",
                    TechStack = "ASP.NET MVC, C#, Razor, AWS (Planned), Authentication (Planned)",
                    Status = "In Progress"
                }


            };
            return View(projects);
        }
    }
}
