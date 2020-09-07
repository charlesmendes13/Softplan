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
            driver.Navigate().GoToUrl("https://localhost:5001/api/CalculaJuros");
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
