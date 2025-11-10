using FinancialControl.Models.DTOs;
using FinancialControl.Models.Entities;
using FinancialControl.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace FinancialControlAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
            
        [HttpPost]
        public IActionResult Create([FromBody] CreatedTransactionDTO transaction)
        {
            var transactionCreated = _transactionService.Add(transaction);
            return Ok(transactionCreated);
        }

        [HttpGet]
        public IActionResult GetTransactions()
        {
            List<Transaction> transactions = _transactionService.GetTransactions();
            return Ok(transactions);    
        }
    }
}
