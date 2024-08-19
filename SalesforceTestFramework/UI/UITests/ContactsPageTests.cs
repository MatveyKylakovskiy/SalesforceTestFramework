using NUnit.Allure.Core;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class ContactsPageTests : BaseTestUI
    {
        [Description("Create Contact Test")]
        [Test]
        public void CreateContactTest()
        {
            var firstName = RandomData.RandomString(8);
            var lastName = RandomData.RandomString(8);

            HomePage.MoveToContactsPage();
            BaseNavigate.CreateNewContact();

            ContactsPage.FirstNameField.InputDataToField(firstName);
            ContactsPage.LastNameField.InputDataToField(lastName);
            ContactsPage.AccountNameField.InputDataToField(settingsUI.BaseAccountName);

            BaseNavigate.SaveEdit();
            
            Assert.That(ContactsPage.IsContactCreated(firstName, lastName), Is.True);
        }
    }
}
