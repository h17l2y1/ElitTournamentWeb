using System.Collections.Generic;
using ElitTournamentWeb.ViewModels.Player;

namespace ElitTournamentWeb.ViewModels.Team
{
	public class TeamItem
	{
		public int? Position { get; set; }

		public string Icon { get; set; }
		
		public string Name { get; set; }

		public int? Played { get; set; }

		public int? Won { get; set; }

		public int? Drawn { get; set; }

		public int? Lost { get; set; }

		public int? Goals { get; set; }

		public int? GoalDifference { get; set; }

		public int? Points { get; set; }

		public IEnumerable<PlayerItem> Players { get; set; }
		
		public int? LeagueId { get; set; }
	}
}