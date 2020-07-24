using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class RoundRepository : BaseRepository<Round>, IRoundRepository
	{
		public RoundRepository(ApplicationContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Round>> GetAll(int seasonId)
		{
			return await _dbSet.Include(i=> i.Places)
									.ThenInclude(ti=> ti.Games)
								.Where(w => w.SeasonId == seasonId)
								.ToListAsync();
			 
		}
	}
}
