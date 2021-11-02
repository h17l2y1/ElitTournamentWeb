using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Place : BaseEntity
	{
		[FirestoreProperty]
		public string Name { get; set; }
		[FirestoreProperty]
		public DateTime Date { get; set; }
		[FirestoreProperty]
		public IEnumerable<Game> Games { get; set; }
		[FirestoreProperty]
		public int RoundId { get; set; }
		[FirestoreProperty]
		public Round Round { get; set; }
	}
}