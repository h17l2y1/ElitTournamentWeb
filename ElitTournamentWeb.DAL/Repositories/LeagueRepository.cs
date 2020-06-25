using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
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


		public async Task<IEnumerable<League>> GetAll(int version)
		{
			throw new System.NotImplementedException();
		}

		public async Task<string> GetTableLink(string teamName, int version)
		{
			throw new System.NotImplementedException();
		}
	}
}
