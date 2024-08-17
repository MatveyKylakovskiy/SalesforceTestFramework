using NUnit.Allure.Core;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class ContactsPageTests : BaseTestUI
    {
        [Test]
        public void CreateContactTest()
        {
            HomePage.MoveToContactsPage();
            BaseNavigate.CreateNewContact();

            ContactsPage.FirstNameField.InputDataToField("first");
            ContactsPage.LastNameField.InputDataToField("Last");
            ContactsPage.AccountNameField.InputDataToField("Adv2");

            BaseNavigate.SaveEdit();

            BaseNavigate.EditItem();

            ContactsPage.FirstNameField.InputDataToField("NewName");

            BaseNavigate.SaveEdit();

            BaseNavigate.DeleteItem();
            
            Assert.Pass();
        }
    }
}
