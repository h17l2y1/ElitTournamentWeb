using System;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElitTournamentWeb.DAL.Config
{
    public static class Firestore
    {
        public static void Add(IServiceCollection services, IConfiguration configuration)
        {
            string firestoreConfigurationPath = GetPathByOs(configuration);
            string projectId = configuration.GetConnectionString("ProjectId");
            string googleCredentials = configuration.GetConnectionString("GoogleEnvironment");

            Environment.SetEnvironmentVariable(googleCredentials, firestoreConfigurationPath);
        
            services.AddTransient<FirestoreDb>(options =>
            {
                FirestoreDb fireStoreDb = FirestoreDb.Create(projectId);
                return fireStoreDb;
            });
        }
        
        private static string GetPathByOs(IConfiguration configuration)
        {
            OperatingSystem os = Environment.OSVersion;
            if (os.Platform == PlatformID.Unix)
            {
                return configuration.GetConnectionString("MacPath");
            }
            
            return configuration.GetConnectionString("WindowsPath");
        }
    }
}