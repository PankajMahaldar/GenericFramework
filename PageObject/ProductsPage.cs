using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFramework.PageObject
{
    public class ProductsPage
    {
        private IWebDriver driver;
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void waitForProductPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Checkout));
        }

        readonly public By Checkout = By.PartialLinkText("Checkout");

        [FindsBy(How=How.TagName,Using ="app-card")]
        private IList<IWebElement> cards;


        public IList<IWebElement> getcards()
        {
            return cards;
        }

    }
}
