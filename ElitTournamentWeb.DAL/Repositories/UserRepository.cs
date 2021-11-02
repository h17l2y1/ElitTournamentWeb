using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(FirestoreDb firestore) : base(firestore)
        {
        }
        
        public async Task<User> FindByLogin(string login)
        {
            // UserOld userOld = await _dbSet.SingleOrDefaultAsync(x => x.Login == login);
            // return userOld;

            return null;
        }
    }
}