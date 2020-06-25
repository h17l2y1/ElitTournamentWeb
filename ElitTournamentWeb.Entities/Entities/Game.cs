using System.ComponentModel.DataAnnotations.Schema;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Game : BaseEntity
	{
		public string Match { get; set; }

		[ForeignKey("ScheduleId")]
		public int ScheduleId { get; set; }

		[NotMapped]
		public virtual Schedule Schedule { get; set; }
	}
}