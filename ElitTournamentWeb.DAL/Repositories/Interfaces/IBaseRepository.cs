﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElitTournamentWeb.DAL.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        Task CreateAsync(TEntity entity);

        Task CreateAsync(IEnumerable<TEntity> collection);

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Update(TEntity entity);
        
        Task Update(IEnumerable<TEntity> entity);

        Task RemoveByIdAsync(int id);

        Task RemoveAsync(TEntity entity);
        Task RemoveAsync(IEnumerable<TEntity> entities);
    }
}
