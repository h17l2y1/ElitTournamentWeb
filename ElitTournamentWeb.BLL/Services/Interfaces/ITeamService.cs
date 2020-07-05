using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.Team;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface ITeamService
	{
		Task<GetTeamsAllResponse> GetAll();

		Task Create(CreateTeamRequest request);
		
		Task Update(UpdateTeamRequest request);
	}
}