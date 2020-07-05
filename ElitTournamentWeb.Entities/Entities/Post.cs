using ElitTournamentWeb.Entities.Types;

namespace ElitTournamentWeb.Entities.Entities
{
	public class Post : BaseEntity
	{
		public PostType Type { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }
		public string Image { get; set; }
	}
}