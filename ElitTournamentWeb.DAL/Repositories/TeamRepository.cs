using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(FirestoreDb firestore): base(firestore)
        {
            CollectionName = $"{nameof(Team)}s";
        }
    }
}