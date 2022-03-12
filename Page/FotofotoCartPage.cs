using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Page
{
    public class FotofotoCartPage : BasePage
    {
        private IWebElement plusbutton => Driver.FindElement(By.CssSelector("body > div.wrapper > div.content > div.cont_cont.text > div.simple_text > div.product_desc > table:nth-child(14) > tbody > tr > td:nth-child(4)"));
        private IWebElement addCartButton => Driver.FindElement(By.CssSelector("body > div.wrapper > div.content > div.cont_cont.text > div.simple_text > div.product_desc > a:nth-child(17)"));
        private IWebElement cartButton => Driver.FindElement(By.CssSelector("body > div.wrapper > div.header > div.krepselis > span.kiekis"));
        public FotofotoCartPage (IWebDriver webDriver) : base(webDriver) { }

        public void Add5UnitToCart()
        {
            for (int i = 1; i < 5; i++)
            {
                plusbutton.Click();
            }
            addCartButton.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(d => cartButton.Text.Equals("6 830.00 € (5)"));
            cartButton.Click();
        }
    }
}
