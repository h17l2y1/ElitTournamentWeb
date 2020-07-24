using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.Round;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface IRoundService
	{
		Task Create(CreateRoundRequest request);
		
		Task<GetAllRoundsResponse> GetAll(int seasonId);
	}
}