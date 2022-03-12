using OpenQA.Selenium;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Tests.Page
{
    public class FotofotoResultPage : BasePage
    {
        private IWebElement price => Driver.FindElement(By.CssSelector(".kaina"));
        private IWebElement cartPrice => Driver.FindElement(By.Id("viso_kaina"));
        private IWebElement productTitle => Driver.FindElement(By.CssSelector(".product_pavadinimas"));
        public FotofotoResultPage(IWebDriver webDriver) : base(webDriver) { }
        public void VerifyPrice(string expectPrice)
        {
            Assert.AreEqual(expectPrice, price.Text, "something wrong");
        }
        public void VerifyCartPrice(string expectedCartPrice)
        {
            Assert.IsTrue(expectedCartPrice.Equals(cartPrice.Text), $"the price {cartPrice.Text} is not than expected");
        }
        public void VerifyAskWindowButton(string expectedText)
        {
            Assert.AreEqual(expectedText, Driver.FindElement(By.CssSelector(".addtocart")).GetAttribute("value").ToString(), "expected result is not correct");
        }
        public void VerifyByName(string productName)
        {
            Assert.AreEqual(productName, productTitle.Text, "product name is not correct!");
        }
    }
}
