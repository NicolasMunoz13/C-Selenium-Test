using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Handler;

namespace TestProject1.PageObjects
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-3794\"]/div/header/h2/a")]
        private IWebElement firstArticle;

        public void clickOnFirstArticle()
        {
            WaitHandler waitTime = new WaitHandler();
            waitTime.waitInSecond(5);
            firstArticle.Click();
        }
    }
}
