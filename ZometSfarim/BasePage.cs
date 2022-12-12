using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ZometSfarim
{
    internal class BasePage
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}