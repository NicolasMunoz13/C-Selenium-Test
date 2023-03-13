using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        public String url = "http://www.swtestacademy.com";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()=\"About\"]")]
        private IWebElement about;


        public void goToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public AboutPage goToAboutPage()
        {
            about.Click();
            return new AboutPage(driver);
        }


    }
}
