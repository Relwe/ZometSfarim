using OpenQA.Selenium;

namespace ZometSfarim
{
    internal class PaymentPage
    {
        public PaymentPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
    }
}