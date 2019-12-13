using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace sampleproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();

            driver.Url = "https://www.hockeyindia.org/";

            driver.Manage().Window.Maximize();
        }
    }
}
