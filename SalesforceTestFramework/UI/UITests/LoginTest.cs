using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;
using System.Collections;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class LoginTests : BaseTestUI
    {

        [TestCaseSource(typeof(LoginData))]
        public void LoginTest(string username, string password, bool expected)
        {
            LoginPage.Login(username, password);

            Assert.That(LoginPage.IsHomeButtonExist(), Is.EqualTo(expected));
        }

    }
}





/*[AllureIssue("UI-123")]
[AllureTms("TMS-456")]
[AllureDescription("Login Test Positive")]
[AllureOwner("Matvey Kylakovskiy")]
[AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]*/