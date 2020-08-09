using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class MenuBar
    {
        [FindsBy(How = How.CssSelector, Using = "b[data-balloon='Media Library']")]
        public IWebElement MediaLibraryMenu { get; set; }

        public const string MediaLibraryMenuElement = "b[data-balloon='Media Library']";
    }
}
