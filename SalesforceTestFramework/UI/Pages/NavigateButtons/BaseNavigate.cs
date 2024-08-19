using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages.NavigateButtons
{
    internal class BaseNavigate
    {
        private static WebElements NewItemButton() => new(By.XPath("//*[@title='New']"));
        private static WebElements NewContactButton() => new(By.XPath("//*[@name='NewContact']"));
        private static WebElements NewReportButtom() => new(By.XPath("//div[@title='New Report']//.."));
        private static WebElements SaveEditButton() => new(By.XPath("//*[@name='SaveEdit']"));
        public static void SaveEdit() => SaveEditButton().Click();
        public static void CreateNewItem() => NewItemButton().Click();
        public static void CreateNewContact() => NewContactButton().Click();
        public static void CreateNewReport() => NewReportButtom().Click();
    }
}
