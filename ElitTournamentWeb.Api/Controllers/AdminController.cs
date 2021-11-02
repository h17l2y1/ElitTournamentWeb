using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ILeagueService _leagueService;

        public AdminController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        [HttpPost]
        public async Task<IActionResult> Init()
        {
            await _leagueService.Init();
            return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> GetAllLeagues()
        {
            var view = await _leagueService.GetAllLeagues();
            return Ok(view);
        }
    }
}