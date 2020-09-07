using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Softplan.Api2.e2e.Tests
{
    public class ShowMeTheCodeTests : IDisposable
    {
        IWebDriver driver;

        public ShowMeTheCodeTests()
        {
            driver = new ChromeDriver();
        }        

        [Fact]
        public void Obter_Url_Git()
        {
            driver.Navigate().GoToUrl("https://localhost:5001/api/ShowMeTheCode");
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
