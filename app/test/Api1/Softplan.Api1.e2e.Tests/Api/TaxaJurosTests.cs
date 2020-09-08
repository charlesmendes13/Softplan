using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net;
using Xunit;

namespace Softplan.Api1.e2e.Tests
{
    public class TaxaJurosTests : IDisposable
    {
        IWebDriver driver;

        public TaxaJurosTests()
        {
            driver = new ChromeDriver();
        }        

        [Fact]
        public void Obter_Taxa_Juros()
        {
            driver.Navigate().GoToUrl("localhost:5001/api/TaxaJuros");

            var response = driver.FindElement(By.TagName("pre")).Text;

            response.Should().Be("0.01");
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
