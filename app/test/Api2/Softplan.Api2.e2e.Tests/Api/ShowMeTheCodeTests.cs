using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api2.e2e.Tests.Api
{
    public class ShowMeTheCodeTests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Obter_Url_Git()
        {
            driver.Navigate().GoToUrl("http://localhost:8002/api/ShowMeTheCode");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
