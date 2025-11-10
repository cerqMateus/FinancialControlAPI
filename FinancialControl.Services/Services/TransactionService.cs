using FinancialControl.Models.DTOs;
using FinancialControl.Models.Entities;
using FinancialControl.Services.Services.Interfaces;

namespace FinancialControl.Services.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly List<Transaction> _transactions = new();
        public Transaction Add(CreatedTransactionDTO transactionDTO)
        {
            if (transactionDTO.AmountInCents <= 0)
            {
                throw new ArgumentException("O valor da transação ser maior que zero.");     
            }

            Transaction newTransaction = new(transactionDTO.Destription, transactionDTO.AmountInCents, transactionDTO.Type);
            _transactions.Add(newTransaction);
            return newTransaction;
        }

        public List<Transaction> GetTransactions() { 
        return _transactions;
        }
    }
}
