using System;

namespace ElitTournamentWeb.ViewModels.Game
{
	public class GameItem
	{
		public int Id { get; set; }
		public int Field { get; set; }
		public string TeamHome { get; set; }
		public string TeamGuest { get; set; }
		public TimeSpan Time { get; set; }
		public int PlaceId { get; set; }
	}
}