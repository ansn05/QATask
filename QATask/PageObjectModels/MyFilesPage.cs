using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class MyFilesPage
    {
        [FindsBy(How = How.ClassName, Using = "upload_button_holder")]
        public IWebElement BrowseButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "div[data-test='advanced-box']")]
        public IWebElement AdvancedButton { get; set; }

        public const string AdvanceButtonLocator = "div[data-test='advanced-box']";


        [FindsBy(How = How.CssSelector, Using = "input[data-test='public-id']")]
        public IWebElement PublicIdField { get; set; }


        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/iframe[2]")]
        public IWebElement MyFilesWindowFrame { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//input[@type='file']")]
        public IWebElement InputFile { get; set; }

        public const string pathToTheFile = "C:\\CloudinaryTest\\Images\\1.jpg";
    }
}
