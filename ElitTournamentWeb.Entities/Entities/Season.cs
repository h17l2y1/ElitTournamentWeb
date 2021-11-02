using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Season : BaseEntity
	{
		[FirestoreProperty]
		public string Name { get; set; }
		[FirestoreProperty]
		public IEnumerable<League> Leagues { get; set; }
	}
}