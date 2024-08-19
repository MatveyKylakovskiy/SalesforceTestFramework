using NUnit.Allure.Core;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class ReportsTests : BaseTestUI
    {
        [Test]
        public void CreateReportTest()
        {   
            HomePage.MoveToReportsPage();
            BaseNavigate.CreateNewReport();
            
            ReportsPage.CreateReport("Contacts & Accounts");
            ReportsPage.RenameReport("NewName");
            ReportsPage.SaveReport();
            
            Assert.That(ReportsPage.IsReportCreated("NewName"), Is.True);
        }
    }
}
