using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Team : BaseEntity
	{
		public Team(string name)
		{
			Name = name;
		}

		public Team() { }
		
		public int? Position { get; set; }

		public string Icon { get; set; }
		
		public string Name { get; set; }

		public int? Played { get; set; }

		public int? Won { get; set; }

		public int? Drawn { get; set; }

		public int? Lost { get; set; }

		public int? Goals { get; set; }

		public int? GoalDifference { get; set; }

		public int? Points { get; set; }

		public IEnumerable<Player> Players { get; set; }
		
		[ForeignKey("LeagueId")]
		public int? LeagueId { get; set; }

		[NotMapped]
		public virtual League League { get; set; }
	}
}