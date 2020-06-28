using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.ViewModels.PostView;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PostController : ControllerBase
	{
		private readonly IPostService _service;
		
		public PostController(IPostService service)
		{
			_service = service;
		}
		
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			PostView view = await _service.GetAllPosts();
			return Ok(view);
		}

	}
}