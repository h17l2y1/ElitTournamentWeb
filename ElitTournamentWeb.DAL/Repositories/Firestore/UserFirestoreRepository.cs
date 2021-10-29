using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories.Firestore
{
    public class UserFirestoreRepository : BaseFirestoreRepository<User>, IUserFirestoreInterface
    {
        static string collectionName = "Users";
        public UserFirestoreRepository(FirestoreDb fireStoreDb) : base(fireStoreDb, collectionName)
        {
        }
        
    }
}