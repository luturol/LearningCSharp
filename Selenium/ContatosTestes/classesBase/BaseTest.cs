using System.IO;
using Microsoft.Extensions.Configuration;

namespace ContatosTestes.classesBase
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