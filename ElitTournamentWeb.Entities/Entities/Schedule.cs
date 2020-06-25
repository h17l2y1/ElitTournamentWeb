using System.Collections;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Schedule : BaseEntity
	{
		public string Place { get; set; }

		public IEnumerable Games { get; set; }
	}
}