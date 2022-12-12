using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ZometSfarim
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver Driver { get; set; }

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            var options = new ChromeOptions();
            options.AddArguments("--start-fullscreen");
            Driver = new ChromeDriver(options);
            
        }

        [ClassCleanup]
        public static void AfterAll()
        {
            Driver.Close();
        }

        [TestMethod]
        public void TestMethod1()
        {
            ZometHomePage zometHomePage = new ZometHomePage(Driver);
            zometHomePage.GotoUrl();
            zometHomePage.ClickAllCategories();
            zometHomePage.MoveToSales();
            var hanukaSalesPage = zometHomePage.ClickHanukaSales();
            hanukaSalesPage.AddFirstBook();
            hanukaSalesPage.ContinueBuy();
            
            hanukaSalesPage.AddSecondBook();
            BeforeCartPage beforeCartPage = hanukaSalesPage.GoToBeforeCart();
            CartPage cartPage = beforeCartPage.GoToCart();
            cartPage.ChooseShipment("1");
            cartPage.FillForm("mail@mail.com", "fName", "lName", "0500000000", "street", "city", "00");
            cartPage.CheckConditions();
            PaymentPage paymentPage = cartPage.GoToPaymentPage();
            zometHomePage.GotoUrl();
            ResultsPage resultsPage = zometHomePage.Search("מעשה בחמישה בלונים");
            resultsPage.Add5BaloonsToCart();


        }
    }
}
