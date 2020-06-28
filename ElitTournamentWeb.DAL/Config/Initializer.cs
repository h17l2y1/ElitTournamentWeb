using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.DAL.Config
{
	public static class Initializer
	{
		public static void SeedData(IServiceCollection services)
		{
			IServiceProvider serviceProvider = services.BuildServiceProvider();
			SeedUsers(serviceProvider).Wait();
		}

		private static async Task SeedUsers(IServiceProvider serviceProvider)
		{
			var context = serviceProvider.GetService<ApplicationContext>();

			if (!context.Users.Any())
			{
				List<User> admins = new List<User>()
				{
					new User() {Login = "admin1", Password = "admin", isAdmin = true, FullName = "Admin1 Adminov1"},
					new User() {Login = "admin2", Password = "admin", isAdmin = true, FullName = "Admin2 Adminov2"}
				};
				
				await context.AddRangeAsync(admins);
				await context.SaveChangesAsync();
			}
		}
	}
}