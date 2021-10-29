using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElitTournamentWeb.DAL.Repositories;
using ElitTournamentWeb.DAL.Repositories.Firestore;
using ElitTournamentWeb.DAL.Repositories.Firestore.Interface;
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
            AddDependencies(services);
            InitializeFirestoreDb(configuration, services);
        }

        private static void InitializeFirestoreDb(IConfiguration configuration, IServiceCollection services)
        {
            OperatingSystem os = Environment.OSVersion;

            
            string macPath = configuration.GetConnectionString("MacPath");
            string windowsPath = configuration.GetConnectionString("WindowsPath");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:/Users/Anuitex-76/Desktop/elittournament-firebase-adminsdk-11w6j-7462ac7bea.json");

            services.AddTransient<FirestoreDb>(options =>
            {
                FirestoreDb fireStoreDb = FirestoreDb.Create("elittournament");
                return fireStoreDb;
            });
            
            
        }
        
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddTransient<IUserFirestoreInterface, UserFirestoreRepository>();
            
            // services.AddTransient<IRoundRepository, RoundRepository>();
            // services.AddTransient<ILeagueRepository, LeagueRepository>();
            // services.AddTransient<ITeamRepository, TeamRepository>();
            // services.AddTransient<IGameRepository, GameRepository>();
            // services.AddTransient<IUserRepository, UserRepository>();
            // services.AddTransient<IPostRepository, PostRepository>();
            // services.AddTransient<ISeasonRepository, SeasonRepository>();
            // services.AddTransient<IPlaceRepository, PlaceRepository>();
        }
    }
}