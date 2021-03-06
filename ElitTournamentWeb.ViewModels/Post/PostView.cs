﻿using System.Collections.Generic;

namespace ElitTournamentWeb.ViewModels.Post
{
	public class PostView
	{
		public PostView(IEnumerable<PostItem> posts)
		{
			Posts = posts;
		}
		
		public IEnumerable<PostItem> Posts { get; set; }
	}

	public class PostItem
	{
		public int Id { get; set; }
		public int Type { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }
		public string Image { get; set; }
	}
}