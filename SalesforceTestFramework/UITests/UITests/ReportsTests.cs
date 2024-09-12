using NUnit.Allure.Core;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class ReportsTests : BaseTestUI
    {
        [Description("Create Report Test")]
        [Test]
        public void CreateReportTest()
        {
            var reporName = RandomData.RandomString(8);

            HomePage.MoveToReportsPage();
            BaseNavigate.CreateNewReport();
            
            ReportsPage.CreateReport("Contacts & Accounts");
            ReportsPage.RenameReport(reporName);
            ReportsPage.SaveReport();
            
            Assert.That(ReportsPage.IsReportCreated(reporName), Is.True);
        }
    }
}
