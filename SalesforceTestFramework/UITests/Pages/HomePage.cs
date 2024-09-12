using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages
{
    public class HomePage
    {
        private static WebElements AppLauncherButton() => new(By.XPath("//*[@title='App Launcher']"));
        private static WebElements SearchAppField() => new(By.XPath("//input[contains(@placeholder, 'Search apps')]"));
        private static WebElements NavigateButton(string pageName) => new(By.XPath($"//*[contains(@class, 'navItem') and @data-id='{pageName}']"));

        private static void MoveToPage(string pageName)
        {   
            AppLauncherButton().Click();
            SearchAppField().SendValue("Service");
            SearchAppField().SendValue(Keys.Enter);
            NavigateButton(pageName).Click();
        }

        public static void MoveToAccountsPage() => MoveToPage("Account");
        public static void MoveToContactsPage() => MoveToPage("Contact");
        public static void MoveToCasesPage() => MoveToPage("Case");
        public static void MoveToReportsPage() => MoveToPage("report");
    }
}
