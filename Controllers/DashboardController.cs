using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MVC1_portfolio.Services;
using Microsoft.AspNetCore.Authorization;


namespace MVC1_portfolio.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DashboardService _dashboardService;
        private readonly StockService _stockService;
        

        public DashboardController()
        {
            _dashboardService = new DashboardService();
            _stockService = new StockService();

        }

        [HttpGet]

        public IActionResult Index(string symbol = "SPY", decimal investmentamount = 0)
        {
            var transactions = TransactionStore.Transactions;

            var model = _dashboardService.BuildDashboard(transactions);

            model.SelectedSymbol = symbol;
            model.SelectedStock = _stockService.GetQuote(symbol);
            

            model.InvestmentAmount = investmentamount;
            model.Shares = _stockService.CalculateShares(investmentamount, model.SelectedStock);

            return View(model); 
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }



    }
}
