using Microsoft.Extensions.Configuration;
using System.IO;

namespace AM.Infrastructure
{
    public static class ConfigurationHelper
    {
        public static string GetConnectionString(string name)
        {
            // Crée un builder qui lit appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // dossier binaire
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = builder.Build();
            return config.GetConnectionString(name);
        }
    }
}