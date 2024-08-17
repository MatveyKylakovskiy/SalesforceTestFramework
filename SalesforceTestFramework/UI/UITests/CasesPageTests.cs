using NUnit.Allure.Core;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class CasesPageTests : BaseTestUI
    {
        [Test]
        public void CreateCaseTest()
        {
            HomePage.MoveToCasesPage();
            BaseNavigate.CreateNewItem();

            CasesPage.StatusField.SelectWorking();

            Assert.Pass();
            
        }
    }
}
