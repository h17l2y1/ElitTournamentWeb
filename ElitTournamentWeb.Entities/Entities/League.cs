using System.Collections.Generic;

namespace ElitTournamentWeb.Entities.Entities
{
	public class League : BaseEntity
	{
		public string Name { get; set; }
		
		public IEnumerable<Team> Teams { get; set; }
	}
}