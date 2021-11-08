using ElitTournamentWeb.DAL.Repositories;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.DAL.Config
{
    public static class Dependencies
    {
        public static void Add(IServiceCollection services)
        {
            services.AddTransient<IRoundRepository, RoundRepository>();
            services.AddTransient<ILeagueRepository, LeagueRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IGameRepository, GameRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<ISeasonRepository, SeasonRepository>();
            services.AddTransient<IPlaceRepository, PlaceRepository>();
        }
    }
}