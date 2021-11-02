using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Player : BaseEntity
	{
		[FirestoreProperty]
		public string FirstName { get; set; }
		[FirestoreProperty]
		public string LastName { get; set; }
		[FirestoreProperty]
		public int Age { get; set; }
	}
}