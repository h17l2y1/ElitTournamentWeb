using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class LeagueRepository : BaseRepository<League>, ILeagueRepository
	{
		public LeagueRepository(ApplicationContext context) : base(context)
		{
		}

		public async override Task<IEnumerable<League>> GetAll()
		{
			IEnumerable<League> result = await _dbSet.Include(x => x.Teams)
													 .ThenInclude(x => x.Players)
													 .AsNoTracking()
													 .ToListAsync();
			return result;
		}
	}
}
