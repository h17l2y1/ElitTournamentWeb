using System.Collections.Generic;

namespace ElitTournamentWeb.ViewModels.Post
{
	public class UpdateManyPostRequest
	{
		public IEnumerable<UpdateManyPostItemRequest> Posts { get; set; }
		public IEnumerable<UpdateManyPostItemRequest> RemovedPosts { get; set; }
	}

	public class UpdateManyPostItemRequest
	{
		public int Id { get; set; }
		public int Type { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }
		public string Image { get; set; }
	}
}