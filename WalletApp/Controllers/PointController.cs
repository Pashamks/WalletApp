using Microsoft.AspNetCore.Mvc;
using WalletBusinessLogic.Interfaces;

namespace WalletApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly IPointManager _pointManager;
        public PointController(IPointManager pointManager)
        {
            _pointManager = pointManager;
        }
        [HttpGet]
        public async Task<IActionResult> CalculatePoints()
        {
            return Ok(await _pointManager.CalculatePoints());
        }
    }
}
