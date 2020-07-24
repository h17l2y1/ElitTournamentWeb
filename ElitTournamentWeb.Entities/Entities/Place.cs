using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Place : BaseEntity
	{
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public IEnumerable<Game> Games { get; set; }
		
		[ForeignKey("RoundId")]
		public int RoundId { get; set; }

		[NotMapped]
		public virtual Round Round { get; set; }
	}
}