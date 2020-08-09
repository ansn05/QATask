using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class PopupMenuPage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Manage')]")]
        public IWebElement ActionAssetManage { get; set; }

        public const string ActionManageLocator = "//div[contains(text(),'Manage')]";
    }
}
