﻿using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.Api.Extensions
{
	public class CorsExtension
	{
		public static void Add(IServiceCollection services)
		{
			// services.AddCors(options =>
			// {
			// 	options.AddPolicy("Angular",
			// 		b => b.WithOrigins("http://localhost:5001")
			// 										.AllowAnyHeader()
			// 										.AllowAnyMethod());
			// });
		}
	}
}