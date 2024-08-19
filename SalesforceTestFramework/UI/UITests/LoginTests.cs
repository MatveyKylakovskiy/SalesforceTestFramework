using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class LoginTests : BaseTestUI
    {
        [AllureEpic("User Management")]
        [AllureFeature("User Creation")]
        [Test]
        [Description("Login test Positive")]
        public void LoginTestPositive()
        {
            allure.StartStep("Start creating user");
            LoginPage.Login(settingsUI.Login, settingsUI.Password);

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.HomeButtonXpath)), Is.True);
            allure.EndStep(Status.passed);
        }
    }
}