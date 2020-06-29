using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Post;

namespace ElitTournamentWeb.BLL.Services
{
	public class PostService : IPostService
	{
		private readonly IMapper _mapper;
		private readonly IPostRepository _postRepository;

		public PostService(IPostRepository postRepository, IMapper mapper)
		{
			_mapper = mapper;
			_postRepository = postRepository;
		}

		public async Task<PostView> GetAllPosts()
		{
			IEnumerable<Post> posts = await _postRepository.GetAll();
			IEnumerable<PostItem> postItems = _mapper.Map<IEnumerable<PostItem>>(posts);
			PostView view = new PostView(postItems);
			return view;
		}

		public async Task Update(UpdatePostRequest request)
		{
			Post post = _mapper.Map<Post>(request);
			await _postRepository.Update(post);
		}
	}
}