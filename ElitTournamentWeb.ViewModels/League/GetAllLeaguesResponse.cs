using System.Collections.Generic;

namespace ElitTournamentWeb.ViewModels.League
{
	public class GetAllLeaguesResponse
	{
		public IEnumerable<LeagueItem> Leagues { get; set; }
	}
	
	public class LeagueItem
	{
		public string Name { get; set; }
		
		public IEnumerable<TeamItem> Teams { get; set; }
	}
	
	public class TeamItem
	{
		public int Position { get; set; }

		public string Icon { get; set; }
		
		public string Name { get; set; }

		public int Played { get; set; }

		public int Won { get; set; }

		public int Drawn { get; set; }

		public int Lost { get; set; }

		public int Goals { get; set; }

		public int GoalDifference { get; set; }

		public int Points { get; set; }

		public IEnumerable<PlayerItem> Players { get; set; }
		
		public int LeagueId { get; set; }
	}

	public class PlayerItem
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }
	}
}