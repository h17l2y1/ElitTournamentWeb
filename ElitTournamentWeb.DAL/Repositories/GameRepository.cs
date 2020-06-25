using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class GameRepository : BaseRepository<Game>, IGameRepository
	{
		public GameRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
