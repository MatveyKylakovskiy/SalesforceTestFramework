using NUnit.Allure.Attributes;
using Allure.NUnit;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class Tests : BaseTestUI
    {
        [AllureOwner("Matvey Kylakovskiy")]
        [AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]
        [AllureIssue("UI-123")]
        [AllureTms("TMS-456")]
        [AllureDescription("Login Test Positive")]
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}