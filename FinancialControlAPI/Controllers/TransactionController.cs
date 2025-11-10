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
            try
            {
                var transactionCreated = _transactionService.Add(transaction);
                return Ok(transactionCreated);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpGet]
        public IActionResult GetTransactions()
        {
            try
            {
                List<Transaction> transactions = _transactionService.GetTransactions();
                return Ok(transactions);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTransactionById(int id)
        {
            try
            {
                Transaction transaction = _transactionService.GetTransactionById(id);
                return Ok(transaction);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpGet("/type/{type}")]
        public IActionResult GetTransactionsByType(string type)
        {
            try
            {
                List<Transaction> transactionsById = _transactionService.GetTransactionsByType(type);
                return Ok(transactionsById);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("/balance")]
        public IActionResult GetBalance()
        {
            try
            {
                double balance = _transactionService.GetBalance();
                return Ok(balance);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
