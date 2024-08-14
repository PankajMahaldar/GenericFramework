using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace GenericFramework.Utilities
{
    public class Base
    {
        public IWebDriver driver;
        
        string BrowserName = ConfigurationManager.AppSettings["Browser"];
        [SetUp]
        public void InvokeBrowser()
        {
            getDriver();
            //invoke the browser
            InitBrowser(BrowserName);
            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Enter URL
            driver.Url = ConfigurationManager.AppSettings["Url"];
        }
        public IWebDriver getDriver()
        {
            return driver;
        }
        public void InitBrowser(string BrowserName)
        {
            switch(BrowserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
            }    
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
