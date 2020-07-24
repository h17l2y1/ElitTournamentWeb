using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Game : BaseEntity
	{
		public int Field { get; set; }
		public string TeamHome { get; set; }
		public string TeamGuest { get; set; }
		public TimeSpan Time { get; set; }

		[ForeignKey("PlaceId")]
		public int PlaceId { get; set; }

		[NotMapped]
		public virtual Place Place { get; set; }
	}
}