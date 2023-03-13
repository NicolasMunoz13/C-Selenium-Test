using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Handler;

namespace TestProject1.PageObjects
{
    public class AboutPage
    {

        private IWebDriver driver;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name=\"s\"]")]
        private IWebElement searchText;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"site-navigation\"]/div/div[2]/span")]
        private IWebElement searchIcon;    

        public ResultPage search(string text)
        {
            WaitHandler waitTime = new WaitHandler();
            waitTime.waitInSecond(5);
            searchIcon.Click();
            searchText.SendKeys(text);
            waitTime.waitInSecond(5);
            searchText.SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }
    }
}
