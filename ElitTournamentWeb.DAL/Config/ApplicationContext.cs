using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Config
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}
		
		public DbSet<User> Users { get; set; }
		
		public DbSet<Schedule> Schedules { get; set; }

		public DbSet<Game> Games { get; set; }

		public DbSet<League> Leagues { get; set; }

		public DbSet<Team> Teams { get; set; }
		
		public DbSet<Player> Players { get; set; }
		
		public DbSet<Post> Posts { get; set; }
		
	}
}