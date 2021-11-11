using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Selenium.Tests
{
    public class Tests
    {
        private IConfiguration configuration;
        
        public Tests()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            
            configuration = builder.Build();
        }

        [Fact]
        public void Test1()
        {
            var pathFirefox = configuration.GetSection("Selenium:PathDriverFirefox").Value;
        }
    }
}
