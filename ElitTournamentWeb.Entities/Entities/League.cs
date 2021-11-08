using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
		
		
		[ForeignKey("SeasonId")]
		public int? SeasonId { get; set; }

		[NotMapped]
		public virtual Season Season { get; set; }
		
		public IEnumerable<Team> Teams { get; set; }
	}
}