using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<UserOld> FindByLogin(string login);
    }
}