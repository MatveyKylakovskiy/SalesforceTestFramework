
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class Tests : BaseTestUI
    {
        [AllureTag("NUnit", "Example")]
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}