using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.Post;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface IPostService
	{
		Task<PostView> GetAllPosts();
		
		Task Update(UpdateManyPostRequest request);
	}
	
}