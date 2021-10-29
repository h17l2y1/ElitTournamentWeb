using ElitTournamentWeb.Api.Extensions;
using ElitTournamentWeb.BLL.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ElitTournamentWeb.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			
			services.InjectBusinessLogicDependency(Configuration);

			services.AddCors(options =>
			{
				options.AddPolicy("Angular",
					b => b.WithOrigins("http://localhost:5001")
						.AllowAnyHeader()
						.AllowAnyMethod());
			});
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();
			
			app.UseCors("Angular");

			app.UseMiddleware<ErrorHandlingMiddleware>();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}