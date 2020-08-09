using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class ManageTopBarPage
    {
        [FindsBy(How = How.CssSelector, Using = "input[data-test='item-title']")]
        public IWebElement ItemTitle { get; set; }

        public const string ItemTitleLocator = "input[data-test='item-title']";

        public const string valueAtribute = "value";
    }
}
