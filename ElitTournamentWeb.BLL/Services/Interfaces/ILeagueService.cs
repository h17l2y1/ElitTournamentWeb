using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.League;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface ILeagueService
	{
		Task<GetAllLeaguesResponse> GetAllLeagues();
		Task CreateLeagues();
		Task CreateLeagues2();
	}
}