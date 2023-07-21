using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WalletBusinessLogic.Interfaces;

namespace WalletApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionManager _transactionManager;
        public TransactionController(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }
        [HttpGet("{transactionId}")]
        public async Task<IActionResult> TransactionDetailsById(int transactionId)
        {
            return Ok(await _transactionManager.TransactionDetailsById(transactionId));
        }
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> TransactionsByUserId(int userId)
        {
            return Ok(await _transactionManager.TransactionsByUserId(userId));
        }
    }
}
