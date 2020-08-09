using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class ReplaceExistingAssetDialog
    {
        public const string ReplaceAssetDialog = "div[data-test='confirm-dialog']";

        [FindsBy(How = How.CssSelector, Using = "button[data-test='confirm-dialog-confirm-btn']")]
        public IWebElement ReplaceButton { get; set; }
    }
}
