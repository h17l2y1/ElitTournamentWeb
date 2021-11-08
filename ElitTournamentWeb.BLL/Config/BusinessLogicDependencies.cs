using ElitTournamentWeb.BLL.Helpers;
using ElitTournamentWeb.BLL.Helpers.Interfaces;
using ElitTournamentWeb.BLL.Services;
using ElitTournamentWeb.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.BLL.Config
{
    public static class BusinessLogicDependencies
    {
        public static void Add(IServiceCollection services)
        {
            services.AddScoped<IJwtHelper, JwtHelper>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ILeagueService, LeagueService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ISeasonService, SeasonService>();
            services.AddScoped<IRoundService, RoundService>();
        }
    }
}