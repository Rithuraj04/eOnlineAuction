using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bidmaster2.Data;
using Bidmaster2.Models;
using Bidmaster2.Dtos;

namespace Bidmaster2.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly TransactionDbContext _context;

        public TransactionService(TransactionDbContext context)
        {
            _context = context;
        }


        public async Task<Transaction> CreateTransactionAsync(TransactionDto model)
        {
            var transaction = new Transaction
            {
                BuyerID = model.BuyerID,
                AuctionID = model.AuctionID,
                Amount = model.Amount
            };
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<Transaction> GetTransactionByIdAsync(int transactionId)
        {
            return await _context.Transactions.FindAsync(transactionId);
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByBuyerAsync(int buyerId)
        {
            return await _context.Transactions
                                 .Where(t => t.BuyerID == buyerId)
                                 .ToListAsync();
        }
    }
}
