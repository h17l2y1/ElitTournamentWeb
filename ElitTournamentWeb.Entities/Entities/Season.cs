using System.Collections.Generic;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Season : BaseEntity
	{
		public string Name { get; set; }

		public IEnumerable<League> Leagues { get; set; }
	}
}