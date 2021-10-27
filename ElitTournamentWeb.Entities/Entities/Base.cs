using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
    public class Base
    {
        public string Id { get; set; } 
    }
    [FirestoreData]
    public class City: Base
    {
        [FirestoreProperty]
        public string Name { get; set; } 
    }
    [FirestoreData]
    public class User : Base
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