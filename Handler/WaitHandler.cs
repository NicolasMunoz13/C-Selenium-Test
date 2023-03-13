using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Handler
{
    public class WaitHandler
    {

        public int MIN_WAIT_SECONDS = 1;
        public int SHORT_WAIT_SECONDS = 5;
        public int NORMAL_WAIT_SECONDS = 15;
        public int MEDIUM_WAIT_SECONDS = 40;
        public int LARGE_WAIT_SECONDS = 60;
        private static int SECONDS_CONVERSION = 1000;

        public void waitWebElementsVisibility(IWebDriver driver, By element, int waitTime)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        public void waitWebElementToBeClickable(IWebDriver driver, By element, int waitTime)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void waitInSecond(int seconds)
        {
            try
            {
                Thread.Sleep(seconds * SECONDS_CONVERSION);
            }
            catch (ThreadInterruptedException ex)
            {
                Thread.CurrentThread.Interrupt();
            }
        }
    }
}
