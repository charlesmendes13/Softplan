using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Softplan.Api1.e2e.Tests.Api
{
    public class TaxaJurosTests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Obter_Taxa_Juros()
        {
            driver.Navigate().GoToUrl("http://localhost:8001/api/TaxaJuros");            
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
