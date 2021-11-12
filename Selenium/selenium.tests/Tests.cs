using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
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
        public void TestFirefox()
        {
            ExecutaGoogle(Browser.Firefox);
        }

        [Fact]
        public void TestChrome()
        {
            ExecutaGoogle(Browser.Chrome);            
        }

        public void ExecutaGoogle(Browser browser)
        {
            TestGoogle google = new TestGoogle(configuration, browser);
            google.LoadPage();

            var results = google.Search("google");        

            Assert.True(results.Count > 0);
            google.ClosePage();
        }
    }
}
