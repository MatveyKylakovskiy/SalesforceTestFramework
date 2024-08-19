using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class AccountsPageTests : BaseTestUI
    {
        [Test]
        [Description("Create Account Test")]
        [AllureIssue("UI-1")]
        [AllureTms("TMS-456")]
        [AllureDescription("Create Account Test")]
        [AllureOwner("Matvey Kylakovskiy")]
        [AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]
        public void CreateAccountTest()
        {   
            HomePage.MoveToAccountsPage();
            BaseNavigate.CreateNewItem();

            AccountsPage.SiteField.InputDataToField("sdsd");
            AccountsPage.TypeField.InputDataToField("Prospect");
            AccountsPage.nameField.InputDataToField("Adv2");
            AccountsPage.DescriptionField.InputDataToField("Description");
            AccountsPage.BillingStritField.InputDataToField("Billing");

            BaseNavigate.SaveEdit();
            Assert.That(AccountsPage.IsAccountCreated("Adv2"), Is.True);

            BaseNavigate.EditItem();

            AccountsPage.nameField.InputDataToField("New");

            BaseNavigate.SaveEdit();
            Assert.That(AccountsPage.IsAccountCreated("New"), Is.True);
        }
    }
}
