using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Round : BaseEntity
	{
		[FirestoreProperty]
		public int RoundNumber { get; set; }
		[FirestoreProperty]
		public IEnumerable<Place> Places { get; set; }
		[FirestoreProperty]
		public int SeasonId { get; set; }
		[FirestoreProperty]
		public virtual Season Season { get; set; }
	}
}