using ElitTournamentWeb.DAL.Repositories;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
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
			Initialize(services);
		}

		private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
		{

			string connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});

			services.Configure<ConnectionStrings>(x => configuration.GetSection("ConnectionStrings").Bind(x));
			services.Configure<AuthOptions>(x => configuration.GetSection("AuthOptions").Bind(x));
		}
		
		private static void Initialize(IServiceCollection services)
		{
			ServiceProvider serviceProvider = services.BuildServiceProvider();

			using (var context = serviceProvider.GetRequiredService<ApplicationContext>())
			{
				if (((RelationalDatabaseCreator) context.Database.GetService<IDatabaseCreator>()).Exists())
				{
					Initializer.SeedData(services);
				}
			}
		}

		public static void AddDependecies(IServiceCollection services)
		{
			services.AddTransient<IScheduleRepository, ScheduleRepository>();
			services.AddTransient<ILeagueRepository, LeagueRepository>();
			services.AddTransient<ITeamRepository, TeamRepository>();
			services.AddTransient<IGameRepository, GameRepository>();
			services.AddTransient<IUserRepository, UserRepository>();
		}
	}
}