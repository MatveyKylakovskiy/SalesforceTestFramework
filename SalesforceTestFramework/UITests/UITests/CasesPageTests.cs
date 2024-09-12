using NUnit.Allure.Core;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class CasesPageTests : BaseTestUI
    {
        [Description("Create Case Test")]
        [Test]
        public void CreateCaseTest()
        {
            var subjectName = RandomData.RandomString(8);

            HomePage.MoveToCasesPage();
            BaseNavigate.CreateNewItem();

            CasesPage.StatusField.SelectWorking();
            CasesPage.CaseOriginField.SelectEmail();
            CasesPage.AccountNameField.InputDataToField(settingsUI.BaseAccountName);
            CasesPage.SubjectField.InputDataToField(subjectName);
            
            BaseNavigate.SaveEdit();

            Assert.That(CasesPage.IsCaseCreated(subjectName), Is.True);
        }
    }
}
