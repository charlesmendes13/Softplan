using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
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
            driver.Navigate().GoToUrl("https://localhost:5001/api/TaxaJuros");            
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
