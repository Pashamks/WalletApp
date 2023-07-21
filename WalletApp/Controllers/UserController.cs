using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletBusinessLogic.Interfaces;

namespace WalletApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        [Route("card")]
        public async Task<IActionResult> CardBalance()
        {
            return Ok(await _userManager.CardBalance());
        }
        [HttpGet]
        [Route("payment")]
        public async Task<IActionResult> PaymentDue()
        {
            return Ok(await _userManager.PaymentDue());
        }
    }
}
