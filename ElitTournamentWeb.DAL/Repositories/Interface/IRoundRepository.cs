using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interface
{
    public interface IRoundRepository: IBaseRepository<Round>
    {
        Task<IEnumerable<Round>> GetAll(int seasonId);
    }
}