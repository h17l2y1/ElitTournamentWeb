using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.ViewModels.Round;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class RoundController : ControllerBase
	{
		private readonly IRoundService _service;

		public RoundController(IRoundService service)
		{
			_service = service;
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateRoundRequest request)
		{
			await _service.Create(request);
			return Ok();
		}
		
		[HttpGet]
		public async Task<IActionResult> GetAll(int seasonId)
		{
			GetAllRoundsResponse response = await _service.GetAll(seasonId);
			return Ok(response);
		}
	}
}