﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.Entities.Types;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.DAL.Config
{
	public static class DataSeeder
	{
		public static void Seed(IServiceCollection services)
		{
			GetDbContext(services);
			SeedData(services);
		}
		
		private static void GetDbContext(IServiceCollection services)
		{
			ServiceProvider serviceProvider = services.BuildServiceProvider();

			using (var context = serviceProvider.GetRequiredService<ApplicationContext>())
			{
				if (((RelationalDatabaseCreator) context.Database.GetService<IDatabaseCreator>()).Exists())
				{
					SeedData(services);
				}
			}
		}
		
		private static void SeedData(IServiceCollection services)
		{
			IServiceProvider serviceProvider = services.BuildServiceProvider();
			SeedUsers(serviceProvider).Wait();
			SeedPosts(serviceProvider).Wait();
			SeedLeagues(serviceProvider).Wait();
			SeedTeams(serviceProvider).Wait();
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

		private static async Task SeedPosts(IServiceProvider serviceProvider)
		{
			var context = serviceProvider.GetService<ApplicationContext>();

			if (!context.Posts.Any())
			{
				List<Post> posts = new List<Post>()
				{
					new Post()
					{
						Type = PostType.RightSide,
						Title =
							"Заявка на весенний elite турнир, который будет проходить на открытых спортплощадках",
						Text =
							"С 19 марта стартует весенний Elite турнир, который будет проходить на открытых спортплощадках: СК Фарм Академия, Football Park, ХНУРЭ.\nТурнир включает в себя 11-12 игр.\nЗаявки уже принимаются. Взнос 5100."
					},
					new Post()
					{
						Type = PostType.RightSide,
						Title = "Заявка на весенний elite cup, который будет проходить в залах",
						Text =
							"С 28 марта стартует весенний Elite Cup, который будет проходить в залах: Ск вирта, ШВСМ Пионер, ОНСК Локомотив, СК Звезда./nТурнир включает в себя 14-15 игр./nЗаявки уже принимаются.Взнос 8000."
					},
					new Post()
					{
						Type = PostType.RightSide,
						Title = "Официальный партнёр ELITE CUP",
						Text = "По вопросам сотрудничества: 0982679156 - Александр",
						Image = "assets/main/obolon.jpg"
					},
					new Post()
					{
						Type = PostType.RightSide,
						Title = "Sport Time",
						Text = "По вопросам сотрудничества: 0982679156 - Александр",
						Image = "assets/main/sport-time.png"
					},
					new Post()
					{
						Type = PostType.RightSide,
						Title = "КУБОК ЭЛИТ-ТУРНИРА",
						Text = "Залы:СК Звезда, ОНСК Локомотив, ШВСМ Пионер, СК Фарм Академия."
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Cхема розыгрыша 6 команд",
						Text =
							"В лиге где играют 6 команд , игры проводятся в 2 круга команды занявшие 1-4 места играют в полуфинальных матчах 1-4 и 2-3 место."
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Cхема розыгрыша 7 команд",
						Text =
							"В Этой лиге выступают 7 коллективов сыграв 6 игр ,команды делятся на первую 4ку и вторую 3ку с сохранением очков проводят еще 2-3 игры ,после чего 1 место в первой 4ке выходит в полуфинал ,а 2-7 место команды будут разыгрывать четвертьфинальные матчи 2-7,3-6,4-5,"
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Cхема розыгрыша 8 команд",
						Text =
							"В Этих лигах играют 8 команд , команды проведут игры по круговой системе в 1 круг,После команды разделяться на 2 четверки (1-4) и (5-8)……в 1 четверке очки у команд сохраняются играется 3 игры .по итогу этих игр 1 и 2 место выходят в полуфинал . 3 и 4 место в четвертьфинал, команды 2 4ки играют 3 игры очки после первого тура у них обнуляются , команды занявшие 1 и 2 место во 2 4ке выходят в четверть финал"
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Cхема розыгрыша 9-10 команд",
						Text =
							"В лигах находиться 9 или 10 команд сыграют в один круг ,после чего 1 и 2 место проходят по прямой в полуфинал ,а команды занявшие места с 3 по 6 будут играть четвертьфинальные матчи , пары 3-6 и 4-5 , в полуфинале 1 м- поб 4-5 ,2м- поб 3-6 , команды занявшие места с 7 по 10 ,будут разыгрывать малый кубок ,полуфинал и финал , пары полуфиналистов мал кубка 7-10 ,8-9,где 9 команд малый кубок будет разыгран между 3 командами 2 круговых игры 1 и 2 место финал"
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Плей-офф",
						Text =
							"В плей-офф матчах при ничейном результате пробивается по 5 6-ти метровых удара, и последняя минута первого и второго тайма играется чистой!"
					},
					new Post()
					{
						Type = PostType.Schedule,
						Title = "Примечания",
						Text =
							"При одинаковом количестве очков у команд, считаются голы, если количество забитых мячей и очков одинаково, и эта игра является последней игрой в круговом турнире перед плей-офф, будет сыграно 2 тайма по 10 минут дополнительного времени. Если по окончанию кругового турнира команды находятся с одинаковыми количествами очков и одинаковое количество мячей, играется для прохода в плей-офф «Золотой матч»."
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text = "За грубый фол игроку будет показана — красная карточка"
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text = "За грубый фол с нанесением травмы – дисквалификация минимум на 3 игры"
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text = "За оскорбление судей, игроков, зрителей – дисквалификация минимум на 3 игры"
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text = "За использование мата на поле – минимальный штраф 50 грн"
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text =
							"За драку — дисквалификация минимум на 5 игры (будет вызван наряд полиции с оформлением протокола на основании статей 121 — 123  «УКУ»)."
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text =
							"В случае повторение нарушение игроку будет запрещено принимать участие в играх Элит-турнира"
					},
					new Post()
					{
						Type = PostType.Punishment,
						Title = "Дисциплинарные наказания",
						Text =
							"Все недовольства и пожелания в организации и проведении Элит-турнира капитаны команд могут написать в протоколе игры после матча."
					},
					new Post()
					{
						Type = PostType.KDKPlayer,
						Title = "КДК по игрокам",
						Text = "Штеплюк Юрий ( Голова КДК )"
					},
					new Post() {Type = PostType.KDKPlayer, Title = "КДК по игрокам", Text = "Гавриков Максим"},
					new Post() {Type = PostType.KDKPlayer, Title = "КДК по игрокам", Text = "Коваленко Игорь"},
					new Post() {Type = PostType.KDKReferee, Title = "КДК по судьям", Text = "Брик Дмитрий"},
					new Post() {Type = PostType.KDKReferee, Title = "КДК по судьям", Text = "Павлов Владимир"},
					new Post() {Type = PostType.KDKReferee, Title = "КДК по судьям", Text = "Данилов Денис"},
				};

				await context.AddRangeAsync(posts);
				await context.SaveChangesAsync();
			}
		}

		private static async Task SeedLeagues(IServiceProvider serviceProvider)
		{
			var context = serviceProvider.GetService<ApplicationContext>();

			if (!context.Leagues.Any())
			{
				List<League> leagues = new List<League>()
				{
					new League("Elit-лига"),
					new League("1-лига"),
					new League("2-лига"),
				};

				await context.AddRangeAsync(leagues);
				await context.SaveChangesAsync();
			}
		}
		
		private static async Task SeedTeams(IServiceProvider serviceProvider)
		{
			var context = serviceProvider.GetService<ApplicationContext>();

			if (!context.Teams.Any())
			{
				List<Team> teams = new List<Team>()
				{
					new Team("Tenko Team"),
					new Team("Если Шо"),
					new Team("ХПС"),
					new Team("Трансинвест"),
					new Team("Олимп"),
					new Team("H.P"),
					
					new Team("Д-12 Виктор +"),
					new Team("West"),
					new Team("X-1"),
					new Team("Salutem"),
					new Team("Fc Баня"),
					new Team("Fakel"),
				};

				await context.AddRangeAsync(teams);
				await context.SaveChangesAsync();
			}
		}
	}
}