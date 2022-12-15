using System;
using MicrosoftVisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Bson;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using static OpenQA.Selenium.IWebDriver;
global using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
	[TestClass]
	public class SeleniumTest
	{
		
		
        private readonly string webAppUri = "https://localhost:7245/";
        private ChromeOptions options;
        private ChromeDriver driver;

        [TestInitialize]
        public void TestInit()
        {
            options = new();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(webAppUri);

            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void TestSearchTVShow()
        {
            WebDriverWait _wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0));

            try
            {
                _wait.Until(d => d.FindElement(By.Id("SearchShow")));
                Assert.IsTrue(true);

            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(false);
            }
        }
        [TestMethod]
        public void TestSearchActor()
        {
            WebDriverWait _wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0));

            try
            {
                _wait.Until(d => d.FindElement(By.Id("SearchActor")));
                Assert.IsTrue(true);

            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(false);
            }
        }

    }
}

