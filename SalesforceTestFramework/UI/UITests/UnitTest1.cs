using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class Tests : BaseTestUI
    {
        
        [Test]
        [AllureOwner("Matvey Kylakovskiy")]
        [AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]
        [AllureIssue("UI-123")]
        [AllureTms("TMS-456")]
        [AllureDescription("Login Test Positive")]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}