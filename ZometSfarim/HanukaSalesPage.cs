using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ZometSfarim
{
    internal class HanukaSalesPage : BasePage
    {
        public HanukaSalesPage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement FirstBook => Driver.FindElements(By.CssSelector(".btn.cart-btn2"))[0];
        public IWebElement SecondBook => Driver.FindElements(By.CssSelector(".btn.cart-btn2"))[1];

        private By ContinueBuyBtnBy => By.ClassName("link-button");
        public IWebElement ContinueBuyBtn => Driver.FindElement(ContinueBuyBtnBy);

        public IWebElement CartBtn => Driver.FindElement(By.CssSelector("a.oprs"));

        internal void AddFirstBook()
        {
            FirstBook.Click();
        }
        internal void AddSecondBook()
        {
            SecondBook.Click();
        }

        internal void ContinueBuy()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ContinueBuyBtnBy));
            ContinueBuyBtn.Click();
        }

        internal BeforeCartPage GoToBeforeCart()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ContinueBuyBtnBy));
            CartBtn.Click();
            return new BeforeCartPage(Driver);
        }
    }
}