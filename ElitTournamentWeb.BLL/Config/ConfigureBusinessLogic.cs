using ElitTournamentWeb.DAL.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.BLL.Config
{
	public static class ConfigureBusinessLogic
	{
		public static void InjectBusinessLogicDependency(this IServiceCollection services, IConfiguration configuration)
		{
			AutoMapper.Add(services);
			BusinessLogicDependencies.Add(services);
			services.InjectDataAccessDependency(configuration);
		}
	}
}