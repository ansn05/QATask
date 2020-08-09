using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QATask
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();

            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }
    }
}
