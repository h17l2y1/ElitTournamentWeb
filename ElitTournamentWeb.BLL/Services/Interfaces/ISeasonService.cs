using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.Season;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface ISeasonService
	{
		Task GetAll();

		Task Create(CreateSeasonRequest requset);
	}
}