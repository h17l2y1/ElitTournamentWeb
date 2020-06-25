using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interfaces
{
	public interface IScheduleRepository : IBaseRepository<Schedule>
	{
		Task<IEnumerable<Schedule>> GetAll(int version);

		Task<string> FindGame(string teamName, int version);
	}
}
