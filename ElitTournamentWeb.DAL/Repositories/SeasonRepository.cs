using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class SeasonRepository : BaseRepository<Season>, ISeasonRepository
    {
        public SeasonRepository(FirestoreDb firestore) : base(firestore)
        {
            CollectionName = $"{nameof(Season)}s";
        }
    }
}