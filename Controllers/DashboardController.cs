using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC1_portfolio.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet] 
        public IActionResult Index()
        {
            var transactions = TransactionStore.Transactions;

            var model = new DashboardViewModel
            {
                CurrentBalance = transactions.Sum(t => t.Amount),
                CreditScore = 776,
                Transactions = transactions
            };

            return View(model);
        }
    }
}
