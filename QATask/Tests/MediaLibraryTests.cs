using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QATask.PageObjectModels;

namespace QATask.Tests
{
    [TestClass]
    public class MediaLibraryTests : BaseTest
    {
        [TestMethod]
        public void UploadImage()
        {
            GoTo(ManagmentConsoleLoginPage.LoginPageUrl);

            var managmentConsoleLoginPage = new ManagmentConsoleLoginPage();
            PageFactory.InitElements(Driver.Instance, managmentConsoleLoginPage);

            ManagmentConsoleLoginPage.Login(ManagmentConsoleLoginPage.loginName, ManagmentConsoleLoginPage.password,
                managmentConsoleLoginPage.UserEmailField, managmentConsoleLoginPage.UserPasswordField,
                managmentConsoleLoginPage.SignInButton);

            Utills.WaitUntillElementVisibleBasedOnCss(MenuBar.MediaLibraryMenuElement);

            var menuBar = new MenuBar();
            PageFactory.InitElements(Driver.Instance, menuBar);

            Utills.OpenMenuElement(menuBar.MediaLibraryMenu);

            var gridViewToolbar = new GridViewToolbar();
            PageFactory.InitElements(Driver.Instance, gridViewToolbar);

            Utills.ClickTheButton(gridViewToolbar.Upload);

            var myFilesPage = new MyFilesPage();
            PageFactory.InitElements(Driver.Instance, myFilesPage);

            Driver.Instance.SwitchTo().Frame(myFilesPage.MyFilesWindowFrame);

            Utills.WaitUntillElementVisibleBasedOnCss(MyFilesPage.AdvanceButtonLocator);
            
            Utills.EnterAssetPublicId(myFilesPage.AdvancedButton, MediaLibraryPage.publicIdValue, myFilesPage.PublicIdField);

            myFilesPage.InputFile.SendKeys(MyFilesPage.pathToTheFile);

            var replaceExistingAssetDialog = new ReplaceExistingAssetDialog();
            PageFactory.InitElements(Driver.Instance, replaceExistingAssetDialog);

            Driver.Instance.SwitchTo().ParentFrame();

           Utills.ReplaceAssetWithTheSamePublicId(ReplaceExistingAssetDialog.ReplaceAssetDialog, replaceExistingAssetDialog.ReplaceButton);

            Assert.IsFalse(Utills.IsElementPresent(By.CssSelector(ReplaceExistingAssetDialog.ReplaceAssetDialog)));

            var mediaLibraryFilesPage = new MediaLibraryPage();
            PageFactory.InitElements(Driver.Instance, mediaLibraryFilesPage);

            Assert.IsTrue(Utills.VerifyIfImageUploaddedValue(mediaLibraryFilesPage.ImageIndex, MediaLibraryPage.ImageIndexAtribute));

            Assert.AreEqual(MediaLibraryPage.publicIdValue, Utills.VerifyPublicIdValue(mediaLibraryFilesPage.ImagePublicId, MediaLibraryPage.publicIdLocator));

            var popupMenuPage = new PopupMenuPage();
            PageFactory.InitElements(Driver.Instance, popupMenuPage);

            Utills.ManageOfTheAsset(popupMenuPage.ActionAssetManage, mediaLibraryFilesPage.ImageCard, PopupMenuPage.ActionManageLocator); 

            Utills.WaitUntillElementVisibleBasedOnCss(ManageTopBarPage.ItemTitleLocator);
            
            var manageTopBarPage = new ManageTopBarPage();
            PageFactory.InitElements(Driver.Instance, manageTopBarPage);

            Assert.AreEqual(MediaLibraryPage.publicIdValue, Utills.VerifyPublicIdValue(manageTopBarPage.ItemTitle, ManageTopBarPage.valueAtribute));
        }

    }
}
