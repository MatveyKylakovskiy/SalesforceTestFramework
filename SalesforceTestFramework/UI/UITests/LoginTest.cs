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

        [Test]
        [Description("Empty Login and Password")]
        public void LoginTestNegative1()
        {
            LoginPage.Login(string.Empty, string.Empty);

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.LogoIconXpath)), Is.True);
        }

        [Test]
        [Description("Empty Login. Not valid Password")]
        public void LoginTestNegative2()
        {
            LoginPage.Login(string.Empty, RandomData.GenerateRandomString(8));

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.LogoIconXpath)), Is.True);
        }

        [Test]
        [Description("Empty Login. Valid Password")]
        public void LoginTestNegative3()
        {
            LoginPage.Login(string.Empty, settingsUI.Password);

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.LogoIconXpath)), Is.True);
        }

        [Test]
        [Description("Valid Login. Empty Password")]
        public void LoginTestNegative4()
        {
            LoginPage.Login(settingsUI.Login, string.Empty);

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.ErrorMesageXpath)), Is.True);
        }

        [Test]
        [Description("Valid Login. Not valid Password")]
        public void LoginTestNegative5()
        {
            LoginPage.Login(settingsUI.Login, RandomData.GenerateRandomString(8));

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.ErrorMesageXpath)), Is.True);
        }

        [Test]
        [Description("Not valid Login and Password")]
        public void LoginTestNegative6()
        {
            LoginPage.Login(RandomData.GenerateRandomString(8), RandomData.GenerateRandomString(8));

            Assert.That(LoginPage.IsElementExist(By.XPath(LoginPage.ErrorMesageXpath)), Is.True);
        }
    }
}






