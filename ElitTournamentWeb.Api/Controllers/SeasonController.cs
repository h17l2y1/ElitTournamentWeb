using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.ViewModels.Season;
using ElitTournamentWeb.ViewModels.Team;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class SeasonController : ControllerBase
	{
		private readonly ISeasonService _seasonService;

		public SeasonController(ISeasonService seasonService)
		{
			_seasonService = seasonService;
		}
			
		// [HttpGet]
		// public async Task<IActionResult> GetAll()
		// {
		// 	var view = await _seasonService.GetAll();
		// 	return Ok(view);
		// }
		
		[HttpPost]
		public async Task<IActionResult> Create(CreateSeasonRequest request)
		{
			await _seasonService.Create(request);
			return Ok();
		}
		
		// [HttpPost]
		// public async Task<IActionResult> Create(UpdateTeamRequest request)
		// {
		// 	await _seasonService.Update(request);
		// 	return Ok();
		// }
	}
}