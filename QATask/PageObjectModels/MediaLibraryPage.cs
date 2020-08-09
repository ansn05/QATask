using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class MediaLibraryPage
    {
        [FindsBy(How = How.CssSelector, Using = "article[data-test='asset-card']")]
        public IWebElement ImageIndex { get; set; }

        public const string ImageIndexAtribute = "data-item-index";


        [FindsBy(How = How.CssSelector, Using = "article")]
        public IWebElement ImageRoot { get; set; }


        [FindsBy(How = How.CssSelector, Using = "img[class='fs-block -assetImage___ke']")]
        public IWebElement ImagePublicId { get; set; }

        public const string publicIdLocator = "alt";
        public const string publicIdValue = "test147";


        [FindsBy(How = How.CssSelector, Using = "article[data-test='asset-card']")]
        public IWebElement ImageCard { get; set; }


        [FindsBy(How = How.XPath, Using = "//iframe[@id='intercom-frame']")]
        public IWebElement MediaLibraryFrame { get; set; }

    }
}
