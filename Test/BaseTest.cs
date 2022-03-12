using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.driver;
using Tests.Page;
using Tests.tools;

namespace Tests.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        protected static fotofotoCartPage CartPage;
        protected static fotofotoHomePage HomePage;
        protected static fotofotoPartnerPage PartnerPage;
        protected static fotofotoProductsPage ProductsPage;
        protected static fotofotoResultPage ResultPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            CartPage = new fotofotoCartPage(driver);
            HomePage = new fotofotoHomePage(driver);
            PartnerPage = new fotofotoPartnerPage(driver);
            ProductsPage = new fotofotoProductsPage(driver);
            ResultPage = new fotofotoResultPage(driver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreeshot(driver);
            }
        }


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}