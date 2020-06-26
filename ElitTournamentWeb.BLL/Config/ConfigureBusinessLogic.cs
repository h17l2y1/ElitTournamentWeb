using AutoMapper;
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
			services.AddScoped<ILeagueService, LeagueService>();
		}
	}
}