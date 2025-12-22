using MVC1_portfolio.Services;
using System.Collections.Generic;

namespace MVC1_portfolio.Models

{
    public class DashboardViewModel
    {
        public decimal CurrentBalance { get; set; }

        public int CreditScore { get; set; }

        public List<Transaction> Transactions { get; set; }

        public decimal NetCashFlow30Days { get; set; }


        //stocks

        public StockQuote SelectedStock { get; set; }

        public string SelectedSymbol { get; set; }

        public decimal InvestmentAmount { get; set; }

        public decimal Shares { get; set; }




    }
}
