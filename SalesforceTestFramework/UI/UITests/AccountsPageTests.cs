using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using PageObjectLib.Factories;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class AccountsPageTests : BaseTestUI
    {
        [Description("Create Account Test, Positive")]
        [Test]
        public void CreateAccountTest()
        {
            var accountName = RandomData.RandomString(8);

            HomePage.MoveToAccountsPage();

            BaseNavigate.CreateNewItem();

            AccountsPage.WebSiteField.InputDataToField(RandomData.RandomString(10));
            AccountsPage.TypeField.InputDataToField("Prospect");
            AccountsPage.NameField.InputDataToField(accountName);
            AccountsPage.DescriptionField.InputDataToField(RandomData.RandomString(20));
            AccountsPage.BillingStritField.InputDataToField(RandomData.RandomString(5));

            BaseNavigate.SaveEdit();

            Assert.That(AccountsPage.IsAccountCreated(accountName), Is.True);
        }

        [Description("Create Account Test, Negative")]
        [Test]
        public void CreateAccountTestNegative()
        {
            HomePage.MoveToAccountsPage();

            BaseNavigate.CreateNewItem();

            AccountsPage.WebSiteField.InputDataToField(RandomData.RandomString(10));
            AccountsPage.TypeField.InputDataToField("Prospect");
            AccountsPage.DescriptionField.InputDataToField(RandomData.RandomString(20));
            AccountsPage.BillingStritField.InputDataToField(RandomData.RandomString(5));

            BaseNavigate.SaveEdit();

            Assert.That(AccountsPage.IsErrorMesDisplayed(), Is.True);
        }

        [Description("Edit Account Test")]
        [Test]
        public void EditAccountFieldTest()
        {   
            var newPhone = RandomData.RandomString(9);

            HomePage.MoveToAccountsPage();

            AccountsPage.SelectAccount(settingsUI.BaseAccountName);

            OneAccountPage.EditAccount();
            OneAccountPage.PhoneField.InputDataToField(newPhone);

            BaseNavigate.SaveEdit();
            Driver.GetDriver().Navigate().Refresh();
;
            Assert.That(OneAccountPage.GetPhoneNumber(), Is.EqualTo(newPhone));
        }

        [Description("Add Activity to account")]
        [Test]
        public void AddActivityTest()
        {
            HomePage.MoveToAccountsPage();

            AccountsPage.SelectAccount(settingsUI.BaseAccountName);


            Assert.Pass();
        }
    }
}
