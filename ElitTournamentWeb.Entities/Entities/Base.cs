using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
    [FirestoreData]
    public class City: BaseEntity
    {
        [FirestoreProperty]
        public string Name { get; set; } 
    }
    [FirestoreData]
    public class User : BaseEntity
    {  
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Surname { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
        [FirestoreProperty]
        public City From { get; set; }
        public string NotBeingSaved { get; set; }
    }
}