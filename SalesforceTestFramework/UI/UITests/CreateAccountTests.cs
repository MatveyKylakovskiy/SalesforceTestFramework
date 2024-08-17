using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SalesforceTestFramework.UI.Pages;
using SalesforceTestFramework.UI.Pages.NavigateButtons;

namespace SalesforceTestFramework.UI.UITests
{
    [AllureNUnit]
    public class CreateAccountTests : BaseTestUI
    {
        [Test]
        [Description("Login test Positive")]
        [AllureIssue("UI-123")]
        [AllureTms("TMS-456")]
        [AllureDescription("Login Test Positive")]
        [AllureOwner("Matvey Kylakovskiy")]
        [AllureLink("Website", "https://qatech5-dev-ed.develop.my.salesforce.com")]
        public void CreateAccountTest()
        {   
            LoginPage.Login(settingsUI.Login, settingsUI.Password);
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
