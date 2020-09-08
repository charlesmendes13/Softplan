using FluentAssertions;
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
            driver.Navigate().GoToUrl("localhost:5002/api/ShowMeTheCode");

            var response = driver.FindElement(By.TagName("pre")).Text;

            response.Should().Be("https://github.com/charlesmendes13/softplan");
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
