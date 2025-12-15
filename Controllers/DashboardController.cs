using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using System;
using System.Collections.Generic;

namespace MVC1_portfolio.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                CurrentBalance = 5234.76m,
                CreditScore = 742,
                Transactions = new List<Transaction>
                {
                    new Transaction
                    {
                        Date = DateTime.Today,
                        Name = "Amazon",
                        Description = "Online purchase",
                        Amount = -129.99m
                    },
                    new Transaction
                    {
                        Date = DateTime.Today.AddDays(-1),
                        Name = "Paycheck",
                        Description = "Direct deposit",
                        Amount = 1800.00m
                    }
                }
            };

            return View(model);
        }
    }
}
