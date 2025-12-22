using MVC1_portfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC1_portfolio.Services
{
    public class DashboardService
    {
        public DashboardViewModel BuildDashboard(List<Transaction> transactions)
        {
            return new DashboardViewModel
            {
                CurrentBalance = transactions.Sum(t => t.Amount),
                CreditScore = 776,
                Transactions = transactions,
                NetCashFlow30Days = CalculateNetCashFlowLast30Days(transactions)
            };
        }
        public decimal CalculateNetCashFlowLast30Days(List<Transaction> transactions)
        {
            var cutoffDate = DateTime.Today.AddDays(-30);

            return transactions
                .Where(t => t.Date >= cutoffDate)
                .Sum(t => t.Amount);
        }
    }
}
