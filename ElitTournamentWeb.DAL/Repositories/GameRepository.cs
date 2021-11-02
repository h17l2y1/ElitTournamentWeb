using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(FirestoreDb firestore) : base(firestore)
        {
            CollectionName = $"{nameof(Game)}s";
        }
    }
}