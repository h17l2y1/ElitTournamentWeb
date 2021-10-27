using System.Threading.Tasks;
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
        private readonly UserFirestoreRepository repository;

        public FirestoreController()
        {
            repository = new UserFirestoreRepository();
        }
        
        		
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserView request)
        {
            var user = new User
            {
                Id = request.Id,
                Name = request.Name,
                Surname = request.Surname
            };
            
            var responseModel = repository.Add(user);
            return Ok(responseModel);
        }
    }
}