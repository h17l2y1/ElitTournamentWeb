using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Round : BaseEntity
	{
		public int RoundNumber { get; set; }
		public IEnumerable<Place> Places { get; set; }
		
		[ForeignKey("SeasonId")]
		public int SeasonId { get; set; }

		[NotMapped]
		public virtual Season Season { get; set; }
	}
}