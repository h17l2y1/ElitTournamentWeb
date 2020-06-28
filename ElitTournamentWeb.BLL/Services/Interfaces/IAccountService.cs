using System.Threading.Tasks;
using ElitTournamentWeb.ViewModels.Auth;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
	public interface IAccountService
	{
		Task<JwtView> LogIn(LogInRequest login);
	}
}