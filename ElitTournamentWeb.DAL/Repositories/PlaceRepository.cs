using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class PlaceRepository : BaseRepository<Place>, IPlaceRepository
	{
		public PlaceRepository(ApplicationContext context) : base(context)
		{
		}
	}
}