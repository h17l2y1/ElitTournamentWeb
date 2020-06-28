using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Auth;

namespace ElitTournamentWeb.BLL.Helpers.Interfaces
{
	public interface IJwtHelper
	{
		JwtView CreateToken(User user);
	}
}