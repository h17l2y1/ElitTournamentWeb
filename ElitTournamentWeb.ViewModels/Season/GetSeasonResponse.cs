using System.Collections.Generic;
using ElitTournamentWeb.ViewModels.League;

namespace ElitTournamentWeb.ViewModels.Season
{
	public class GetSeasonResponse
	{
		public string Name { get; set; }
		public IEnumerable<LeagueItem> Leagues { get; set; }
	}
}