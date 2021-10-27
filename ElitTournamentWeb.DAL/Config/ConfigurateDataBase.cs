using System;
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
using FireSharp.Config;
using Google.Cloud.Firestore;


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

            // FirestoreDb db = FirestoreDb.Create("elittournament");

            
            // try
            // {
            //     var auth = new FirebaseAuthProvider(new FirebaseConfig(cls_keys.ApiKey));
            //     var ab = await auth.SignInWithEmailAndPasswordAsync(model.Email, model.Password);
            //     string token = ab.FirebaseToken;
            //     var user = ab.User;
            //     if (token != "")
            //     {
            //         string _struserRole = "false";
            //         HttpContext.Session.SetString("bt_userEmail", model.Email);
            //         HttpContext.Session.SetString("bt_userToken", token);
            //         HttpContext.Session.SetString("bt_userRole", _struserRole);
            //         return RedirectToAction("Index", "Storage");
            //     }
            // }
            // catch (Exception ex)
            // {
            //
            // }
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
            services.AddDbContext<ApplicationContext>(options => { options.UseSqlServer(connectionString); });

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