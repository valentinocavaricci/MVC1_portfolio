using MVC1_portfolio.Models;
using System;
using System.Collections.Generic;

namespace MVC1_portfolio.Services
{
    public class StockService
    {
        private readonly Dictionary<string, StockQuote> _mockQuotes = new Dictionary<string, StockQuote>
        {
            { "SPY", new StockQuote { Symbol = "SPY", CurrentPrice = 512.34m, DailyChangePercent = 0.42m } },
                { "AAPL", new StockQuote { Symbol = "AAPL", CurrentPrice = 189.21m, DailyChangePercent = -0.37m } },
                { "MSFT", new StockQuote { Symbol = "MSFT", CurrentPrice = 421.55m, DailyChangePercent = 0.81m } }
        };

        public StockQuote GetQuote(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                symbol = "SPY";
            }

            _mockQuotes.TryGetValue(symbol.ToUpper(), out var quote);
            return quote;
        }

        public decimal CalculateShares(decimal investmentAmount, StockQuote quote)
        {
            if (quote == null || investmentAmount <= 0)
            {
                return 0;
            }
            var shares = investmentAmount / quote.CurrentPrice;

            return shares;
        }
    }
}
