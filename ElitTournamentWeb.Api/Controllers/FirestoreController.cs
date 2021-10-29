using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Firestore;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElitTournamentWeb.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FirestoreController: ControllerBase
    {
        private readonly IFirestoreService _service;

        public FirestoreController(IFirestoreService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]UserView request)
        {
            var responseModel = _service.Add(request);
            return Ok(responseModel);
        }
    }
}