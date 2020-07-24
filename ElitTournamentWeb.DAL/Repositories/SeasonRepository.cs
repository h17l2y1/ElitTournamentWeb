using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class SeasonRepository : BaseRepository<Season>, ISeasonRepository
	{
		public SeasonRepository(ApplicationContext context) : base(context)
		{
		}
	}
}