using ElitTournamentWeb.DAL.Repositories;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ElitTournamentWeb.DAL.Config
{
	public static class ConfigurateDataBase
	{
		public static void InjectDataAccessDependency(this IServiceCollection services, IConfiguration configuration)
		{
			AddDbContext(services, configuration);
			AddDependecies(services);
		}

		private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
		{
			string connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});

			services.Configure<ConnectionStrings>(x => configuration.GetSection("ConnectionStrings").Bind(x));
		}

		public static void AddDependecies(IServiceCollection services)
		{
			services.AddTransient<IScheduleRepository, ScheduleRepository>();
			services.AddTransient<ILeagueRepository, LeagueRepository>();
			services.AddTransient<ITeamRepository, TeamRepository>();
			services.AddTransient<IGameRepository, GameRepository>();
		}
	}
}