using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ZometSfarim
{
    internal class CartPage : BasePage
    {
        public IWebElement Email => Driver.FindElement(By.Id("email"));
        public IWebElement FirstName => Driver.FindElement(By.Id("customerFirstName"));
        public IWebElement LastName => Driver.FindElement(By.Id("customerLastName"));
        public IWebElement Phone => Driver.FindElement(By.Id("phone"));
        public IWebElement City => Driver.FindElement(By.Id("city"));
        public IWebElement Street => Driver.FindElement(By.Id("street"));
        public IWebElement HomeNum => Driver.FindElement(By.Id("homenum"));
        public IWebElement Shipment => Driver.FindElement(By.Id("shipment"));
        public IWebElement UseConditions => Driver.FindElement(By.Id("isConfirm"));
        public IWebElement ToPayment => Driver.FindElement(By.Id("form-submit-button"));

        public CartPage(IWebDriver driver) : base(driver)
        {
            
        }        

        internal void FillForm(string email, string fName, string lName, string phone,
            string city, string street, string homeNum)
        {
            Email.SendKeys(email);
            FirstName.SendKeys(fName);
            LastName.SendKeys(lName);
            Phone.SendKeys(phone);
            City.SendKeys(city);
            Street.SendKeys(street);
            HomeNum.SendKeys(homeNum);
        }

        internal PaymentPage GoToPaymentPage()
        {
            ToPayment.Click();
            return new PaymentPage(Driver);
        }

        internal void ChooseShipment(string value)
        {
            var shipment = new SelectElement(Shipment);
            shipment.SelectByValue(value);
        }

        internal void CheckConditions()
        {
            UseConditions.Click();
        }


    }
}