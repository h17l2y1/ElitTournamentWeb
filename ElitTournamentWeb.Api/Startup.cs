using ElitTournamentWeb.Api.Extensions;
using ElitTournamentWeb.BLL.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
			services.InjectBusinessLogicDependency(Configuration);

			CorsExtension.Add(services);
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

			
			app.UseCors("AllowAllPolicy");
			app.UseMiddleware<ErrorHandlingMiddleware>();
			
			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}