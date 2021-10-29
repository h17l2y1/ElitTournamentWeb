using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class LeagueRepository: BaseRepository<League>, ILeagueRepository
    {
        public LeagueRepository(FirestoreDb firestore): base(firestore)
        {
        }
        
        // public async override Task<IEnumerable<League>> GetAll()
        // {
        //     IEnumerable<League> result = await _dbSet.Include(x => x.Teams)
        //         .ThenInclude(x => x.Players)
        //         .AsNoTracking()
        //         .ToListAsync();
        //     return result;
        // }
        
    }
}