using Microsoft.AspNetCore.Mvc;
using MVC1_portfolio.Models;

namespace MVC1_portfolio.Controllers
{
    public class TransactionsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(TransactionStore.Transactions);
        }

        [HttpPost]
        public IActionResult Add(Transaction transaction)
        {
            TransactionStore.Transactions.Add(transaction);
            return RedirectToAction("Index");
        }

        [HttpPost]

        public IActionResult Delete(int index)
        {
            if (index >= 0 && index < TransactionStore.Transactions.Count)
            {
                TransactionStore.Transactions.RemoveAt(index);
            }

            return RedirectToAction("Index");
        }


    }
}
