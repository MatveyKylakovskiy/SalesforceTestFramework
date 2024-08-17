using PageObjectLib.Elements;
using OpenQA.Selenium;
using SalesforceTestFramework.UI.Fields.CreateAccountFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class AccountsPage
    {
        public static NameField nameField = new();
        public static WebsiteField SiteField = new();
        public static DescriptionField DescriptionField = new();
        public static BillingStritField BillingStritField = new();
        public static TypeField TypeField = new();
        public static bool IsAccountCreated(string accountName) => WebElements.IsElementDisplayed(By.XPath($"//*[@slot='primaryField' and text()='{accountName}']"));
    }
}
