using System;
using System.Collections.Generic;

namespace MVC1_portfolio.Models
{
    public static class TransactionStore
    {
        public static List<Transaction> Transactions { get; } = new List<Transaction>
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
        };
    }
}
