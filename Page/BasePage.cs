using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Page
{
    public class BasePage
    {

        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;

        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }

    }
}
