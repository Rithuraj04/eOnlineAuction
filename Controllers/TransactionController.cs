using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Bidmaster2.Models;
using Bidmaster2.Dtos;
using Bidmaster2.Services;
namespace Bidmaster2.Controllers
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

        [HttpPost("create")]
        public async Task<IActionResult> CreateTransaction(TransactionDto transaction)
        {
            var result =await  _transactionService.CreateTransactionAsync(transaction);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionById(int id)
        {
            var result = await _transactionService.GetTransactionByIdAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("buyer/{buyerId}")]
        public async Task<IActionResult> GetTransactionsByBuyer(int buyerId)
        {
            var result = await _transactionService.GetTransactionsByBuyerAsync(buyerId);
            return Ok(result);
        }
    }
}
