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
            CasesPage.ContactNameField.InputDataToField(settingsUI.BaseContactName);
            CasesPage.AccountNameField.InputDataToField(settingsUI.BaseAccountName);
            CasesPage.SubjectField.InputDataToField(subjectName);
            
            BaseNavigate.SaveEdit();

            Assert.True(CasesPage.IsCaseCreated(subjectName));
        }
    }
}
