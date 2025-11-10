
using FinancialControl.Models.DTOs;
using FinancialControl.Models.Entities;

namespace FinancialControl.Services.Services.Interfaces
{
    public interface ITransactionService
    {
        Transaction Add(CreatedTransactionDTO transaction);
        List<Transaction> GetTransactions();
        Transaction GetTransactionById(int id);
        List<Transaction> GetTransactionsByType(string type);
        double GetBalance();
    }
}
