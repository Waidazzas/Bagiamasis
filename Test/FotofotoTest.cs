using NUnit.Framework;

namespace Tests.Test
{
    public  class FotofotoTest : BaseTest
    {
        [Test]

        public static void Test1FujifilmXt4Price()
        {
            HomePage.NavigateToPage();
            HomePage.AcceptCookie();
            HomePage.SearchByCommodity("fujifilm xt4");
            HomePage.ChoosingProduct("Fujifilm X-T4 body (Sidabrinis)");
            ResultPage.VerifyPrice("1 366.00 €");
        }
        [Test]
        public static void Test2FujifilmXt4ManyPrice()
        {
            HomePage.NavigateToPage();
            HomePage.AcceptCookie();
            HomePage.SearchByCommodity("fujifilm xt4");
            HomePage.ChoosingProduct("Fujifilm X-T4 body (Sidabrinis)");
            CartPage.Add5UnitToCart();
            ResultPage.VerifyCartPrice("Iš viso 6 830.00 €");
        }
        [Test]
        public static void Test3FujifilmXt4AskWindow()
        {
            HomePage.NavigateToPage();
            HomePage.AcceptCookie();
            HomePage.SearchByCommodity("fujifilm xt4");
            HomePage.SearchDropDown("Fujifilm X-T4 body (Sidabrinis)");
            ProductsPage.ClickOnAskButton("Teirautis");
            ResultPage.VerifyAskWindowButton("Teirautis");
        }
        [Test]
        public static void Test4FujifilmXt4Comparison()
        {
            HomePage.NavigateToPage();
            HomePage.AcceptCookie();
            HomePage.MoveToMainLineMenu("Fotoaparatai");
            HomePage.ChoosingAnOption("Fujifilm (83)");
            ProductsPage.ChangeFilterOptions();
            ProductsPage.LookingForProduct("Fujifilm X-T30 body (Sidabrinis)");
            ProductsPage.ClickOnComparisonButton();
            ResultPage.VerifyByName("Fujifilm X-T30 body (Sidabrinis)");
        }
        [Test]
        public static void Test5FujifilmXt4CheckPartnerPage()
        {
            HomePage.NavigateToPage();
            HomePage.AcceptCookie();
            HomePage.ClickOnPartnerPage();
            PartnerPage.SendKey("fujifilm xt4");
            PartnerPage.GoToResults("Fotoaparatas Fujifilm X-T4");
            PartnerPage.ChooseRightPage("fotofoto.lt");
            ResultPage.VerifyByName("Fujifilm X-T4 body (Juodas)");
        }
    }
}
