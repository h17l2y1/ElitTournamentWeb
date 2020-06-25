using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interfaces
{
	public interface ILeagueRepository : IBaseRepository<League>
	{
		Task<IEnumerable<League>> GetAll(int version);

		Task<string> GetTableLink(string teamName,int version);
	}
}
