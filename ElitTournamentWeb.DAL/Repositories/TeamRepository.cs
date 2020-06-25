using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class TeamRepository : BaseRepository<Team>, ITeamRepository
	{
		public TeamRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
