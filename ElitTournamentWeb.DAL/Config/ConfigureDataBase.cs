using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
namespace ElitTournamentWeb.DAL.Config
{
    public static class ConfigureDataBase
    {
        public static void InjectDataAccessDependency(this IServiceCollection services, IConfiguration configuration)
        {
            Firestore.Add(services, configuration);
            DatabaseDependencies.Add(services);
        }
    }
}