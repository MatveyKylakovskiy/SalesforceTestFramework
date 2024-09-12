using PageObjectLib.Elements;
using OpenQA.Selenium;
using SalesforceTestFramework.UI.Fields.CreateAccountFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class AccountsPage
    {
        public static NameField NameField = new();
        public static WebsiteField WebSiteField = new();
        public static DescriptionField DescriptionField = new();
        public static BillingStritField BillingStritField = new();
        public static TypeField TypeField = new();

        private static WebElements ErrorMessage() => new(By.XPath("//div[text()='Complete this field.']"));
        private static WebElements AccountSiteTitle(string siteName) => new(By.XPath($"//span[@data-aura-class='uiOutputText' and text()='{siteName}']"));
        private static WebElements AccountLink(string accountName) => new(By.XPath($"//*[@data-refid='recordId' and @title='{accountName}']"));

        public static bool IsAccountCreated(string accountName) => WebElements.IsElementDisplayed(By.XPath($"//*[@slot='primaryField' and text()='{accountName}']"));
        public static bool IsAccountExist(string accountName) => WebElements.IsElementDisplayed(By.XPath($"//*[text()='{accountName}']"));
        public static bool IsErrorMesDisplayed() => ErrorMessage().IsElementVisible();
        public static bool IsSiteNameChanged(string siteName) => AccountSiteTitle(siteName).GetText() == siteName;
        public static void SelectAccount(string accountName) => AccountLink(accountName).Click();
    }
}
