﻿using ElitTournamentWeb.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElitTournamentWeb.DAL.Config
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
		
		public DbSet<Schedule> Schedules { get; set; }

		public DbSet<Game> Games { get; set; }

		public DbSet<League> Leagues { get; set; }

		public DbSet<Team> Teams { get; set; }
		
		public DbSet<Player> Players { get; set; }
		
	}
}