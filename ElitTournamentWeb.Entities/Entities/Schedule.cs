using System;
using System.Collections.Generic;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Schedule : BaseEntity
	{
		public string Place { get; set; }

		public DateTime Date { get; set; }
		
		public IEnumerable<Game> Games { get; set; }
	}
}