using System;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Game : BaseEntity
	{
		[FirestoreProperty]
		public int Field { get; set; }
		[FirestoreProperty]
		public string TeamHome { get; set; }
		[FirestoreProperty]
		public string TeamGuest { get; set; }
		[FirestoreProperty]
		public TimeSpan Time { get; set; }
		[FirestoreProperty]
		public int PlaceId { get; set; }
		[FirestoreProperty]
		public virtual Place Place { get; set; }
	}
}