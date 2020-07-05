using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.ViewModels.Team;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class TeamController : ControllerBase
	{
		private readonly ITeamService _teamService;

		public TeamController(ITeamService teamService)
		{
			_teamService = teamService;
		}
			
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var view = await _teamService.GetAll();
			return Ok(view);
		}
		
		[HttpPost]
		public async Task<IActionResult> Create(CreateTeamRequest request)
		{
			await _teamService.Create(request);
			return Ok();
		}
		
		[HttpPost]
		public async Task<IActionResult> Create(UpdateTeamRequest request)
		{
			await _teamService.Update(request);
			return Ok();
		}
	}
	
}