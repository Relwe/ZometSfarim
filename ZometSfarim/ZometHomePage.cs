using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ZometSfarim
{
    internal class ZometHomePage : BasePage
    {
        public ZometHomePage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        By HanukaSalesBy = By.XPath("//*[@id='sub-categories-container']/div[1]/a[6]");
        public IWebElement AllCategories => Driver.FindElement(By.CssSelector(".menu[role='button']"));
        public IWebElement Sales => Driver.FindElement(By.XPath("//*[@data-id='250']"));

        public IWebElement HanukaSales => Driver.FindElement(HanukaSalesBy);

        public IWebElement SearchField => Driver.FindElement(By.Id("top-search"));

        internal HanukaSalesPage ClickHanukaSales()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(HanukaSalesBy));
            HanukaSales.Click();
            return new HanukaSalesPage(Driver);
        }

        internal void GotoUrl()
        {
            Driver.Navigate().GoToUrl("https://www.booknet.co.il/");
        }

        internal void MoveToSales()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(Sales);
        }

        internal void ClickAllCategories()
        {
            AllCategories.Click();
        }

        internal ResultsPage Search(string v)
        {
            SearchField.SendKeys(v);
            SearchField.Submit();
            return new ResultsPage(Driver);
        }
    }
}