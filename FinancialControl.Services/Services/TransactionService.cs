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
            if (!_transactions.Any())
            {
                throw new InvalidOperationException("Não existe nenhuma transação registrada até o momento.");
            }
        return _transactions;
        }

        public Transaction GetTransactionById(int id)
        {
            Transaction transaction = _transactions.FirstOrDefault(t=> t.Id == id);
            if(transaction == null)
            {
                throw new InvalidOperationException("Transação não encontrada");
            }
            return transaction;
        }

        public List<Transaction> GetTransactionsByType(string type)
        {
            List<Transaction> transactionsByType = _transactions.Where(t => t.Type.Equals(type)).ToList();
            if (!transactionsByType.Any())
            {
                throw new InvalidOperationException($"Não existe nenhuma transação com o tipo {type}.");
            }
            return transactionsByType;
        }
    }
}
