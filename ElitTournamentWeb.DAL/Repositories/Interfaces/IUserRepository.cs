using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interfaces
{
	public interface IUserRepository : IBaseRepository<UserOld>
	{
		Task<UserOld> FindByLogin(string login);
	}
}