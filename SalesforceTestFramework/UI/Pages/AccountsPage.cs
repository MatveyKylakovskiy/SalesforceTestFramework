using PageObjectLib.Elements;
using OpenQA.Selenium;
using SalesforceTestFramework.UI.Fields.CreateAccountFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class AccountsPage
    {
        public static NameField NameField = new();
        public static WebsiteField SiteField = new();
        public static DescriptionField DescriptionField = new();
        public static BillingStritField BillingStritField = new();
        public static TypeField TypeField = new();
        public static bool IsAccountCreated(string accountName) => WebElements.IsElementDisplayed(By.XPath($"//*[@slot='primaryField' and text()='{accountName}']"));
        private static WebElements ErrorMessage() => new(By.XPath("//div[text()='Complete this field.']"));
        private static WebElements AccountSiteTitle(string siteName) => new(By.XPath($"//span[@data-aura-class='uiOutputText' and text()='{siteName}']"));
        public static bool IsErrorMesDisplayed() => ErrorMessage().IsElementVisible();
        public static bool IsSiteNameChanged(string siteName) => AccountSiteTitle(siteName).GetText() == siteName;

        private static WebElements AccountLink(string accountName) => new(By.XPath($"//*[@data-refid='recordId' and @title='{accountName}']"));
        public static void SelectAccount(string accountName) => AccountLink(accountName).Click();
    }
}
