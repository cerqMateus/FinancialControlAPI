using FinancialControl.Models.Entities;
using FinancialControl.Services.Services.Interfaces;

namespace FinancialControl.Services.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly List<Transaction> _transactions = new();
        public Transaction Add(Transaction transaction)
        {
            _transactions.Add(transaction);
            return transaction;
        }

        public List<Transaction> GetTransactions() { 
        return _transactions;
        }
    }
}
