using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class User : BaseEntity
	{
		[FirestoreProperty]
		public string Login { get; set; }
		[FirestoreProperty]
		public string FullName { get; set; }
		[FirestoreProperty]
		public string Password { get; set; }
		[FirestoreProperty]
		public bool IsAdmin { get; set; }
	}
}