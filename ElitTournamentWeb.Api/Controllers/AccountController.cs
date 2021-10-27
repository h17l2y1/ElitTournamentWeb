using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.ViewModels.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class AccountController : Controller
	{
		private readonly IAccountService _service;
		public AccountController(IAccountService service)
		{
			_service = service;
		}
		
		[HttpPost]
		public async Task<IActionResult> LogIn([FromBody] LogInRequest logInRequest)
		{
			var responseModel = await _service.LogIn(logInRequest);
			return Ok(responseModel);
		}

	}
}