using System.IO;
using Microsoft.Extensions.Configuration;
using selenium.tests.Classes;
using Selenium.Tests.Classes;
using Xunit;

namespace Selenium.Tests
{
    public class SearchGoogleTest : BaseTest
    {
        public SearchGoogleTest() : base()
        {            
        }
     
        [Theory]
        [InlineData(Browser.Chrome)]
        [InlineData(Browser.Firefox)]
        public void ExecutaGoogle(Browser browser)
        {
            Google google = new Google(configuration, browser);
            google.LoadPage();

            var results = google.Search("google");        

            Assert.True(results.Count > 0);
            google.ClosePage();
        }
    }
}
