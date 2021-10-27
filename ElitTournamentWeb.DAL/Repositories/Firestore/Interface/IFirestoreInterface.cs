using System.Collections.Generic;

namespace ElitTournamentWeb.DAL.Repositories.Firestore.Interface
{
    public interface IFirestoreInterface<TEntity>
    {
        TEntity Get(TEntity record);
        List<TEntity> GetAll();
        TEntity Add(TEntity record);
        bool Update(TEntity record);
        bool Delete(TEntity record);
    }
}