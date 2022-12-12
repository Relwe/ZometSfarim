using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ZometSfarim
{
    internal class BeforeCartPage : BasePage
    {

        public BeforeCartPage(IWebDriver driver) : base(driver)
        {
           
        }

        public IWebElement Cart => Driver.FindElement(By.XPath("//*[@id='jumptohere']/section/div[2]/div[1]/p[1]/a/img"));

        internal CartPage GoToCart()
        {
            Cart.Click();
            return new CartPage(Driver);
        }
    }
}