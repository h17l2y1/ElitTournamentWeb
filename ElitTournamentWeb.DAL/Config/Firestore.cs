using System;
using ElitTournamentWeb.DAL.Models;
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
            string projectId = configuration.GetSection("Firestore:ProjectId").Value;
            string googleCredentials = configuration.GetSection("Firestore:GoogleEnvironment").Value;
            
            Environment.SetEnvironmentVariable(googleCredentials, firestoreConfigurationPath);
        
            services.AddTransient<FirestoreDb>(options =>
            {
                FirestoreDb fireStoreDb = FirestoreDb.Create(projectId);
                return fireStoreDb;
            });
        }
        
        // Only for my case
        private static string GetPathByOs(IConfiguration configuration)
        {
            OperatingSystem os = Environment.OSVersion;
            if (os.Platform == PlatformID.Unix)
            {
                return configuration.GetSection("Firestore:MacPath").Value;
            }
            return configuration.GetSection("Firestore:WindowsPath").Value;
        }
    }
}