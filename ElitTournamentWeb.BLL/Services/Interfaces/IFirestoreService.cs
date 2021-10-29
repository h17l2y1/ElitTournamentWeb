using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels;

namespace ElitTournamentWeb.BLL.Services.Interfaces
{
    public interface IFirestoreService
    {
        Task<User> Add(UserView request);
    }
}