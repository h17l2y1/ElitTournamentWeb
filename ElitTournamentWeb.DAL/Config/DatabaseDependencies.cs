using ElitTournamentWeb.DAL.Repositories.Firestore;
using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.DAL.Config
{
    public static class DatabaseDependencies
    {
        public static void Add(IServiceCollection services)
        {
            services.AddTransient<IUserFirestoreInterface, UserFirestoreRepository>();
            
            // services.AddTransient<IRoundRepository, RoundRepository>();
            // services.AddTransient<ILeagueRepository, LeagueRepository>();
            // services.AddTransient<ITeamRepository, TeamRepository>();
            // services.AddTransient<IGameRepository, GameRepository>();
            // services.AddTransient<IUserRepository, UserRepository>();
            // services.AddTransient<IPostRepository, PostRepository>();
            // services.AddTransient<ISeasonRepository, SeasonRepository>();
            // services.AddTransient<IPlaceRepository, PlaceRepository>();
        }
    }
}