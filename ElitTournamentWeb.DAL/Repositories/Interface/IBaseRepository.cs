using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElitTournamentWeb.DAL.Repositories.Interface
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> Get(TEntity record);
        
        Task<List<TEntity>> GetAll();

        Task<TEntity> Add(TEntity record);

        Task Add(List<TEntity> records);

        Task<TEntity> Update(TEntity record);
        
        Task<string> Delete(TEntity record);
    }
}