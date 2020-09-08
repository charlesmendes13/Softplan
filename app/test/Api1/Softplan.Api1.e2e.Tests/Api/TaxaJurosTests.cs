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
            driver.Navigate().GoToUrl("localhost:5001/api/TaxaJuros");

            System.Threading.Thread.Sleep(3000);
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
