using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFramework.PageObject
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        #region Locators

        [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        private IWebElement UserName;

        public IWebElement getUserName()
        {
            return UserName;
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        private IWebElement Password;
        public IWebElement getPassword()
        {
            return Password;
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='terms']")]
        private IWebElement CheckBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='signInBtn']")]
        private IWebElement SignIn;
        #endregion


        #region Methods
        public ProductsPage ValidLogin(String UserInput,String Pass)
        {
            UserName.SendKeys(UserInput);
            Password.SendKeys(Pass);
            CheckBox.Click();
            SignIn.Click();
            return new ProductsPage(driver);
        }
        #endregion

    }
}
