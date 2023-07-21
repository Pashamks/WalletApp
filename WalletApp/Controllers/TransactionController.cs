using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WalletApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public TransactionController()
        {

        }
        [HttpGet("{transactionId}")]
        public async Task<IActionResult> TransactionDetailsById(int transactionId)
        {
            return Ok();
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> TransactionsByUserId(int userId)
        {
            return Ok();
        }
    }
}
