using System.Collections.Generic;
using ElitTournamentWeb.ViewModels.Place;

namespace ElitTournamentWeb.ViewModels.Round
{
	public class RoundItem
	{
		public int RoundNumber { get; set; }
		public int SeasonId { get; set; }
		public IEnumerable<PlaceItem> Places { get; set; }
	}
}