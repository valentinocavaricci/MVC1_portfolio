using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using System.Collections.Generic;
using System.Linq;

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
                    Description = "An MVC contact form demonstrating model validation, POST handling, and a repository to ensure appropriate seperation of concerns.",
                    TechStack = "ASP.NET MVC, C#, Razor",
                    Status = "Complete",
                    Link = "/Contact",
               
                },

                new Project
                {
                    Title = "Secure Authenticated Dashboard",
                    Description = "An ASP.NET MVC dashboard feature secured with AWS Cognito authentication, built to practice implementing login and protected pages and features.",
                    TechStack = "ASP.NET MVC, AWS Cognito",
                    Status = "Complete"
                },

                new Project
                {
                    Title = "Triple DES Implementation",
                    Description = "A Python implementation of the Triple DES algorithm, demonstrating the use of the DES algorithm to encrypt and decrypt data.",
                    TechStack = "Python, DES",
                    Status = "Complete",
                    Link = "https://github.com/valentinocavaricci/Triple-DES-in-Python"
                },

                new Project
                {
                    Title = "BRAG — Senior Project: Social Media Application",
                    Description = "A capstone project focused on building a social-style portfolio platform where users can showcase achievements as posts. Designed to demonstrate full-stack abilties, authentication, and backend abilities.",
                    TechStack = "ASP.NET MVC, C#, Razor, AWS , Authentication",
                    Status = "In Progress"
                }



            };

            var orderedprojects = projects.OrderByDescending(p => p.Status == "Complete").ToList();
            return View(orderedprojects);
        }
    }
}
