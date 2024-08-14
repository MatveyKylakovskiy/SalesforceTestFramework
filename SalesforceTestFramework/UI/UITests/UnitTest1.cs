
using NUnit.Allure.Attributes;

namespace SalesforceTestFramework.UI.UITests
{
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