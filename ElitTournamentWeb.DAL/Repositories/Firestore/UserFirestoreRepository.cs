using System.Collections.Generic;
using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
using ElitTournamentWeb.Entities.Entities;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.DAL.Repositories.Firestore
{
    public class UserFirestoreRepository : IFirestoreInterface<User>
    {
        string collectionName = "Users";
        BaseFirestoreRepository repo;

        public UserFirestoreRepository()
        {
            repo = new BaseFirestoreRepository(collectionName);
        }

        public User Add(User record) => repo.Add(record);
        public bool Update(User record) => repo.Update(record);
        public bool Delete(User record) => repo.Delete(record);
        public User Get(User record) => repo.Get(record);
        public List<User> GetAll() => repo.GetAll<User>();

        public List<User> GetUserWhereCity()
        {
            List<City> cities = new List<City>()
            {
                new City()
                {
                    Name = "Test City"
                }
            };
            Query query = repo.fireStoreDb.Collection(collectionName).WhereIn(nameof(User.From), cities);
            return repo.QueryRecords<User>(query);
        }
    }
}