using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class League : BaseEntity
	{
		public League(string name)
		{
			Name = name;
		}

		public League()
		{
		}
		
		[FirestoreProperty]
		public string Name { get; set; }
		
		[FirestoreProperty]
		public IEnumerable<Team> Teams { get; set; }
		[FirestoreProperty]
		public int SeasonId { get; set; }
		[FirestoreProperty]
		public virtual Season Season { get; set; }
	}
}