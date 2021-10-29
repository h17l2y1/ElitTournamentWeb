using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels;

namespace ElitTournamentWeb.BLL.Services
{
    public class FirestoreService : IFirestoreService
    {
        private readonly IUserFirestoreInterface _repo;

        public FirestoreService(IUserFirestoreInterface repo)
        {
            _repo = repo;
        }
        		
        public async Task<User> Add(UserView request)
        {
            var user = new User
            {
                Id = request.Id,
                Name = request.Name,
            };
            
            User response = _repo.Add(user);
            return response;
        }
    }
}