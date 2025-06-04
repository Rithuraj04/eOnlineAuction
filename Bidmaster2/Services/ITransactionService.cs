using Bidmaster2.Dtos;
using Bidmaster2.Models;

namespace Bidmaster2.Services
{
    public interface ITransactionService
    {
         Task<Transaction> CreateTransactionAsync(TransactionDto model);
        Task<Transaction> GetTransactionByIdAsync(int transactionId);
        Task<IEnumerable<Transaction>> GetTransactionsByBuyerAsync(int buyerId);
    }
}
