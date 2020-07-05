using System.Collections.Generic;

namespace ElitTournamentWeb.Entities.Entities
{
	public class League : BaseEntity
	{
		public League(string name)
		{
			Name = name;
		}
		
		public League() { }
		
		public string Name { get; set; }
		
		public IEnumerable<Team> Teams { get; set; }
	}
}