using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace ElitTournamentWeb.Entities.Entities
{
	[FirestoreData]
	public class Team : BaseEntity
	{
		public Team(string name, string leagueId)
		{
			Name = name;
			LeagueId = leagueId;
		}

		public Team()
		{
		}
		
		[FirestoreProperty]
		public int? Position { get; set; }
		[FirestoreProperty]
		public string Icon { get; set; }
		[FirestoreProperty]
		public string Name { get; set; }
		[FirestoreProperty]
		public int? Played { get; set; }
		[FirestoreProperty]
		public int? Won { get; set; }
		[FirestoreProperty]
		public int? Drawn { get; set; }
		[FirestoreProperty]
		public int? Lost { get; set; }
		[FirestoreProperty]
		public int? Goals { get; set; }
		[FirestoreProperty]
		public int? GoalDifference { get; set; }
		[FirestoreProperty]
		public int? Points { get; set; }
		[FirestoreProperty]
		public IEnumerable<Player> Players { get; set; }
		[FirestoreProperty]
		public string LeagueId { get; set; }
		[FirestoreProperty]
		public League League { get; set; }
	}
}