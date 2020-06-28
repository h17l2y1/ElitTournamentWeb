using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.PostView;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface IPostService
	{
		Task<PostView> GetAllPosts();
	}
	
}