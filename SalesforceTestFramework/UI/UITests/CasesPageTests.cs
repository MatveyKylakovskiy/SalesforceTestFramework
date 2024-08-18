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
            CasesPage.CaseOriginField.SelectEmail();
            CasesPage.ContactNameField.InputDataToField(settingsUI.BaseContactName);
            CasesPage.AccountNameField.InputDataToField(settingsUI.BaseAccountName);
            CasesPage.SubjectField.InputDataToField("MyCase2");
            
            

            BaseNavigate.SaveEdit();

            Assert.True(CasesPage.IsCaseCreated("MyCase2"));
            
        }
    }
}
