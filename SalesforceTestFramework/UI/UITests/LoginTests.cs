using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class LoginTests : BaseTestUI
    {
        [Test]
        [Description("Login test Positive")]
        [AllureIssue("UI-123")]
        [AllureTms("TMS-456")]
        [AllureDescription("Login Test Positive")]
        [AllureOwner("Matvey Kylakovskiy")]
        [AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]
        public void LoginTestPositive()
        {
            LoginPage.Login(settingsUI.Login, settingsUI.Password);

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.HomeButtonXpath)), Is.True);
        }
    }
}