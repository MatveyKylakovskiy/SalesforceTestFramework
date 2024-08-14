using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class Tests : BaseTestUI
    {
        [AllureStep("Step Description")]
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}