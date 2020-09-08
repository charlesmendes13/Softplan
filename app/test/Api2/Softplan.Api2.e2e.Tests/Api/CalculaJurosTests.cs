using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Softplan.Api2.e2e.Tests
{
    public class CalculaJurosTests : IDisposable
    {
        IWebDriver driver;

        public CalculaJurosTests()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void Calcula_Juros()
        {
            driver.Navigate().GoToUrl("localhost:5002/api/CalculaJuros?valorInicial=100&meses=5");

            var response = driver.FindElement(By.TagName("pre")).Text;

            response.Should().Be("105.1");
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
