using NUnit.Allure.Core;
using PageObjectLib.Factories;
using SalesforceTestFramework.AppSettings.AppSettingsUI;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class BaseTestUI
    {
        public SettingsUI settingsUI;

        [SetUp]
        public void Setup()
        {
            settingsUI = new SettingsUI();

            Driver.CreateDriver(settingsUI.Driver);
            Driver.GoUrl(settingsUI.URL);
            LoginPage.Login(settingsUI.Login, settingsUI.Password);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }
}
