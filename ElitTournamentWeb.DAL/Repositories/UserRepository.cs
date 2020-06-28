using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(ApplicationContext context) : base(context)
		{
		}

		public async Task<User> FindByLogin(string login)
		{
			User user = await _dbSet.SingleOrDefaultAsync(x => x.Login == login);
			return user;
		}
	}
}