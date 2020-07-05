using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.Api.Extensions
{
	public class CorsExtension
	{
		public static void Add(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("AllowAllPolicy",
					b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials().WithExposedHeaders("Token-Expired"));

				options.AddPolicy("OriginPolicy",
					b => b.WithOrigins("http://localhost:5001").AllowAnyHeader().AllowAnyMethod().AllowCredentials());
			});
		}
	}
}