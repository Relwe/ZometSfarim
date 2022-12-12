using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ZometSfarim
{
    internal class ResultsPage : BasePage
    {
        public ResultsPage(IWebDriver driver) : base(driver)
        {
            
        }

        public IWebElement Add5BaloonsToCartBtn => Driver.FindElement(By.XPath("//*[@id='jumptohere']/section/div[2]/div/div[3]/div/button"));

        internal void Add5BaloonsToCart()
        {
            Add5BaloonsToCartBtn.Click();
        }
    }
}