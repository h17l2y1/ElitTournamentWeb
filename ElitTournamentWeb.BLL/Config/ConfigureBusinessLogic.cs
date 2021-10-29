using AutoMapper;
using ElitTournamentWeb.BLL.Helpers;
using ElitTournamentWeb.BLL.Helpers.Interfaces;
using ElitTournamentWeb.BLL.Services;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.BLL.Config
{
	public static class ConfigureBusinessLogic
	{
		public static void InjectBusinessLogicDependency(this IServiceCollection services, IConfiguration configuration)
		{
			AddAutoMapper(services);
			AddDependency(services);

			services.InjectDataAccessDependency(configuration);
		}


		private static void AddAutoMapper(IServiceCollection services)
		{
			var config = new MapperConfiguration(c => { c.AddProfile(new MapperProfile()); });

			IMapper mapper = config.CreateMapper();

			services.AddSingleton(mapper);
		}

		private static void AddDependency(IServiceCollection services)
		{
			services.AddScoped<IJwtHelper, JwtHelper>();
			services.AddScoped<IAccountService, AccountService>();
			services.AddScoped<IPostService, PostService>();
			services.AddScoped<ILeagueService, LeagueService>();
			services.AddScoped<ITeamService, TeamService>();
			services.AddScoped<ISeasonService, SeasonService>();
			services.AddScoped<IRoundService, RoundService>();
			services.AddScoped<IFirestoreService, FirestoreService>();
		}
	}
}