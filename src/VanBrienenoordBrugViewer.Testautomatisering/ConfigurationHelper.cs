using System.IO;
using Microsoft.Extensions.Configuration;

namespace DocumentStore.Testautomatisering
{
    static class ConfigurationHelper
    {
        public static IConfiguration AppSetting { get; }

        static ConfigurationHelper()
        {
            AppSetting = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
