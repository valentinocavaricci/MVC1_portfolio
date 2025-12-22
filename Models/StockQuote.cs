namespace MVC1_portfolio.Models
{
    public class StockQuote
    {
        public string Symbol { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal DailyChangePercent { get; set; }
    }
}
