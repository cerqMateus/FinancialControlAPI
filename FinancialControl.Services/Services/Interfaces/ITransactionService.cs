
using FinancialControl.Models.DTOs;
using FinancialControl.Models.Entities;

namespace FinancialControl.Services.Services.Interfaces
{
    public interface ITransactionService
    {
        Transaction Add(CreatedTransactionDTO transaction);
        List<Transaction> GetTransactions();
      
    }
}
