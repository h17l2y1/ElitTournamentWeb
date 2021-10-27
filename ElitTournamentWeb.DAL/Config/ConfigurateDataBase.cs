using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
// using FireSharp;
// using FireSharp.Config;
// using FireSharp.Interfaces;
// using FireSharp.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Firebase.Database;
using Firebase.Database.Query;


namespace ElitTournamentWeb.DAL.Config
{
	public static class ConfigurateDataBase
	{
		public static void InjectDataAccessDependency(this IServiceCollection services, IConfiguration configuration)
		{
			AddDependecies(services);
			// AddFirebaseRealTimeDb(configuration);
			AddFirebaseFirestoreDb(configuration);
			// AddDbContext(services, configuration);
			// Initialize(services);
		}

		private static void AddFirebaseFirestoreDb(IConfiguration configuration)
		{
			var auth1 = "9pUaH0iXjo1Wsy68022E4wqYPSmJa3jttgRLulZT"; // secret
			var auth2 = "AIzaSyApRC2PP15sBr1b3ih2OmwH3w7OZudYsqI"; // apiKey
			
			
			var firebase = new FirebaseClient(
				"https://elittournament-default-rtdb.europe-west1.firebasedatabase.app",
				new FirebaseOptions
				{
					AuthTokenAsyncFactory = () => Task.FromResult(auth2) 
				});
			
			var dino = firebase
				.Child("testColl")
				.PostAsync(new Student("fdhfd", "Ivan Ivanov"));

		}
		
		// private static void AddFirebaseRealtimeDb(IConfiguration configuration)
		// {
		// 	IFirebaseConfig config = new FirebaseConfig
		// 	{
		// 		AuthSecret = configuration.GetConnectionString("AuthSecret"),
		// 		BasePath = configuration.GetConnectionString("BasePath"),
		// 	};
		// 	
		// 	IFirebaseClient client = new FirebaseClient(config);
		// 	
		// 	Student student = new Student("fdhfd", "Ivan Ivanov");
		// 	PushResponse response = client.Push("Students/", student);
		// 	student.Id = response.Result.name;
		// 	SetResponse setResponse = client.Set("Students/" + student.Id, student);
		// 	
		// 	
		// 	FirebaseResponse response2 = client.Get("Students");
		// 	dynamic data = JsonConvert.DeserializeObject<dynamic>(response2.Body);
		// 	var list = new List<Student>();
		// 	foreach(var item in data)
		// 	{
		// 		list.Add(JsonConvert.DeserializeObject<Student>(((JProperty)item).Value.ToString()));
		// 	}
		//
		// }
		
		private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
		{
			string connectionString = configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<ApplicationContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});

			// services.Configure<ConnectionStrings>(x => configuration.GetSection("ConnectionStrings").Bind(x));
			// services.Configure<AuthOptions>(x => configuration.GetSection("AuthOptions").Bind(x));
		}
		
		private static void Initialize(IServiceCollection services)
		{
			ServiceProvider serviceProvider = services.BuildServiceProvider();

			using (var context = serviceProvider.GetRequiredService<ApplicationContext>())
			{
				if (((RelationalDatabaseCreator) context.Database.GetService<IDatabaseCreator>()).Exists())
				{
					Initializer.SeedData(services);
				}
			}
		}

		public static void AddDependecies(IServiceCollection services)
		{
			services.AddTransient<IRoundRepository, RoundRepository>();
			services.AddTransient<ILeagueRepository, LeagueRepository>();
			services.AddTransient<ITeamRepository, TeamRepository>();
			services.AddTransient<IGameRepository, GameRepository>();
			services.AddTransient<IUserRepository, UserRepository>();
			services.AddTransient<IPostRepository, PostRepository>();
			services.AddTransient<ISeasonRepository, SeasonRepository>();
			services.AddTransient<IPlaceRepository, PlaceRepository>();
		}
	}

	public class Student
	{
		public Student(string id, string fullname)
		{
			Id = id;
			Fullname = fullname;
		}

		public Student()
		{
		}
		
		public string Id { get; set; }
		public string Fullname { get; set; }
	}
}