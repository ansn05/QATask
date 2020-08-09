using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QATask.PageObjectModels
{
    public class ManagmentConsoleLoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "#user_session_email")]
        public IWebElement UserEmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#user_session_password")]
        public IWebElement UserPasswordField { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#sign-in")]
        public IWebElement SignInButton { get; set; }


        public const string LoginPageUrl = "https://cloudinary.com/users/login";
        public const string loginName = "terrierqq12@gmail.com";
        public const string password = "Hexagram666$";

        public static void Login(string loginName, string password, IWebElement userEmailField, 
            IWebElement userPasswordField, IWebElement button)
        {
            Utills.EnterDataIntoTheField(loginName, userEmailField);
            Utills.EnterDataIntoTheField(password, userPasswordField);
            Utills.ClickTheButton(button);
        }

    }
}
