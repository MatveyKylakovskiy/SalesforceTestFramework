using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages
{
    public class AccountPage
    {
        private static WebElements MenuButton() => new(By.XPath("//*[contains(@class, 'menu-button')]//button"));
        private static WebElements EditButton() => new(By.XPath("//*[@apiname='Edit']"));

        public static void EditAccount()
        {
            MenuButton().Click();
            EditButton().Click();
        }
    }
}
