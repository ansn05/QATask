using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QATask
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        
        [TestCleanup]
        public void CleanUp()
        {
            Driver.Instance.Quit();
            Driver.Instance.Dispose();
        }

        public static void GoTo(string link)
        {
            Driver.Instance.Navigate().GoToUrl(link);
        }
        }
}
