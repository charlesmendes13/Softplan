using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Softplan.Api2.e2e.Tests.Api
{
    public class CalculaJurosTests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Calcula_Juros()
        {
            driver.Navigate().GoToUrl("http://localhost:8002/api/CalculaJuros");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
