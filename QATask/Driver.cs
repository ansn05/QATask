using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
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
