using System.Collections.Generic;
using ElitTournamentWeb.ViewModels.Team;

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
}