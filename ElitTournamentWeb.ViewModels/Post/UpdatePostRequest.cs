namespace ElitTournamentWeb.ViewModels.Post
{
	public class UpdatePostRequest
	{
		public int Id { get; set; }
		public int Type { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }
		public string Image { get; set; }
	}
}