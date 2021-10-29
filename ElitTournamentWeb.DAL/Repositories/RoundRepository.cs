using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class RoundRepository: BaseRepository<Round>, IRoundRepository
    {
        public RoundRepository(FirestoreDb firebase): base(firebase)
        {
        }
        
        public async Task<IEnumerable<Round>> GetAll(int seasonId)
        {
            // return await _dbSet.Include(i=> i.Places)
            //     .ThenInclude(ti=> ti.Games)
            //     .Where(w => w.SeasonId == seasonId)
            //     .ToListAsync();
            return null;
        }
    }
}