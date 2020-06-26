using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories
{
	public class ScheduleRepository : BaseRepository<Schedule>, IScheduleRepository
	{
		private IScheduleRepository _scheduleRepositoryImplementation;

		public ScheduleRepository(ApplicationContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Schedule>> GetAll(int version)
		{
			return await _scheduleRepositoryImplementation.GetAll(version);
		}

		public async Task<string> FindGame(string teamName, int version)
		{
			return await _scheduleRepositoryImplementation.FindGame(teamName, version);
		}
	}
}
