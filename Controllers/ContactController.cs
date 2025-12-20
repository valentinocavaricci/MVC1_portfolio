using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using MVC1_portfolio.Repositories;
using Amazon.DynamoDBv2;
using System;
using System.Threading.Tasks;

namespace MVC1_portfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactRepository _repository;

  
        public ContactController(IAmazonDynamoDB dynamoDb)
        {
            _repository = new ContactRepository(dynamoDb);
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            return View(new ContactViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var record = new ContactRecord
            {
                ContactId = Guid.NewGuid().ToString(),
                FName = model.FirstName,  
                LName = model.LastName,      
                Email = model.Email,
                Message = model.Message,
                CreatedAt = DateTime.UtcNow.ToString("o")
            };

            await _repository.SaveAsync(record);

            TempData["SuccessMessage"] = "Thank you! Your message has been sent.";
            return RedirectToAction(nameof(Index));
        }
    }
}
