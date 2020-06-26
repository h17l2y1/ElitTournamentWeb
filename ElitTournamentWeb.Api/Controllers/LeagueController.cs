using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElitTournamentWeb.BLL.Services.Interfaces;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class LeagueController : ControllerBase
	{
		private readonly ILeagueService _leagueService;

		public LeagueController(ILeagueService leagueService)
		{
			_leagueService = leagueService;
		}
			
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var view = await _leagueService.GetAllLeagues();
			return Ok(view);
		}
	}
}