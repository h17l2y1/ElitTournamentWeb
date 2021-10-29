using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels;
using ElitTournamentWeb.ViewModels.Post;

namespace ElitTournamentWeb.BLL.Services
{
	public class PostService : IPostService
	{
		private readonly IMapper _mapper;
		private readonly IPostRepository _postRepository;
		private readonly IUserFirestoreInterface _repository;

		public PostService(IPostRepository postRepository, IMapper mapper, IUserFirestoreInterface repository)
		{
			_mapper = mapper;
			_postRepository = postRepository;
			_repository = repository;
		}

		public async Task<PostView> GetAllPosts()
		{
			IEnumerable<Post> posts = await _postRepository.GetAll();
			IEnumerable<PostItem> postItems = _mapper.Map<IEnumerable<PostItem>>(posts);
			PostView view = new PostView(postItems);
			return view;
		}
		
		public async Task Update(UpdateManyPostRequest request)
		{
			IEnumerable<Post> updatePosts = _mapper.Map<IEnumerable<Post>>(request.Posts);
			IEnumerable<Post> removePosts = _mapper.Map<IEnumerable<Post>>(request.RemovedPosts);

			// await _postRepository.CreateAsync(updatePosts.Where(x=>x.Id == 0));
			// await _postRepository.Update(updatePosts.Where(x=>x.Id != 0));
			await _postRepository.RemoveAsync(removePosts);
		}
	}
}