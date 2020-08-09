using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
   public class GridViewToolbar
    {
        [FindsBy(How = How.CssSelector, Using = "button[data-test='upload-btn']")]
        public IWebElement Upload { get; set; }
    }
}
