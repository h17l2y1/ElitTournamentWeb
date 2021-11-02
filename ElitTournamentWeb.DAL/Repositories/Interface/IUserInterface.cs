﻿using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;

namespace ElitTournamentWeb.DAL.Repositories.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindByLogin(string login);
    }
}