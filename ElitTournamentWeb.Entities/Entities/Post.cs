using ElitTournamentWeb.Entities.Types;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Post : BaseEntity
	{
		[FirestoreProperty]
		public PostType Type { get; set; }
		[FirestoreProperty]
		public string Title { get; set; }
		[FirestoreProperty]
		public string Description { get; set; }
		[FirestoreProperty]
		public string Text { get; set; }
		[FirestoreProperty]
		public string Image { get; set; }
	}
}