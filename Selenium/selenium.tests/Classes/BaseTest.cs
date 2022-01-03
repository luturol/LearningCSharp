using System.IO;
using Microsoft.Extensions.Configuration;

namespace selenium.tests.Classes
{
    public abstract class BaseTest
    {
        public IConfiguration configuration;

        public BaseTest()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }
    }
}