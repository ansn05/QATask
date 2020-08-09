using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace QATask
{
    public class Utills
    {
        public static void EnterDataIntoTheField(string text, IWebElement element)
        {
            element.SendKeys(text);
        }

        public static void ClickTheButton(IWebElement element)
        {
            element.Click();
        }
        
        public static string VerifyPageTitle()
        {
            var title = Driver.Instance.Title;
            return title;
        }
        
        public static void WaitUntillElementVisibleBasedOnCss(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, System.TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }

        public static void WaitUntillElementVisibleBasedOnXpath(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, System.TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }


        public static void OpenMenuElement(IWebElement element)
        {
            element.Click();
        }
        
        public static bool VerifyIfImageUploaddedValue(IWebElement element, string atributeName)
        {
            var imageIndex = element.GetAttribute(atributeName);

            if (imageIndex == "0")
            {
                return true;
            }
            return false;
        }

        public static string VerifyPublicIdValue(IWebElement element, string atributeName)
        {
            var publicId = element.GetAttribute(atributeName);

            if (publicId != null)             {
                return publicId;
            }
            return null;
        }

        public static void RightClick(IWebElement element, string elementlocator)
        {
            Actions actions = new Actions(Driver.Instance);
            actions.ContextClick(element).Perform();
            Utills.WaitUntillElementVisibleBasedOnXpath(elementlocator);
        }

        public static void ManageOfTheAsset(IWebElement elementMenu, IWebElement element, string elementlocator)
        {
            RightClick(element, elementlocator);
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(elementMenu).Build().Perform();
            actions.Click().Build().Perform() ;
        }

        public static void EnterAssetPublicId(IWebElement advanceButton, string publicIdValue, IWebElement publicIdField)
        {
            ClickTheButton(advanceButton);

            EnterDataIntoTheField(publicIdValue, publicIdField);

            ClickTheButton(advanceButton);
        }

        public static void ReplaceAssetWithTheSamePublicId(string dialogWindow, IWebElement replaceButton)
        {
            if (IsElementPresent(By.CssSelector(dialogWindow)))
            {
                ClickTheButton(replaceButton);
            }
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                Driver.Instance.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
