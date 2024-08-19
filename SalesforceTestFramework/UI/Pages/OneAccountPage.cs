using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesforceTestFramework.UI.Fields;
using SalesforceTestFramework.UI.Fields.EditAccountFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class OneAccountPage
    {
        public static PhoneField PhoneField = new();
        private static WebElements MenuButton() => new(By.XPath("//*[contains(@class, 'menu-button')]//button"));
        private static WebElements EditButton() => new(By.XPath("//*[@apiname='Edit']"));
        private static WebElements PhoneNumberItem() => new(By.XPath("//lightning-formatted-phone//a"));

        public static void EditAccount()
        {
            MenuButton().Click();
            EditButton().Click();
        }

        public static string GetPhoneNumber() => PhoneNumberItem().GetText();
    }
}
