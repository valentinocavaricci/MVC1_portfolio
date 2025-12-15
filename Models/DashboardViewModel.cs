using System.Collections.Generic;

namespace MVC1_portfolio.Models

{
    public class DashboardViewModel
    {
        public decimal CurrentBalance { get; set; }

        public int CreditScore { get; set; }

        public List<Transaction> Transactions { get; set; }


    }
}
