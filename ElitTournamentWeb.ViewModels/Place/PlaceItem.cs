using System;
using System.Collections.Generic;
using ElitTournamentWeb.ViewModels.Game;

namespace ElitTournamentWeb.ViewModels.Place
{
	public class PlaceItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public int RoundId { get; set; }
		public IEnumerable<GameItem> Games { get; set; }
	}
}