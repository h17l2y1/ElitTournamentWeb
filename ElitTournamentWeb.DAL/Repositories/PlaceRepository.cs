using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories
{
    public class PlaceRepository: BaseRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(FirestoreDb firestore): base(firestore)
        {
        }
    }
}