using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages.NavigateButtons
{
    internal class BaseNavigate
    {
        private static WebElements NewItemButton() => new(By.XPath("//*[@title='New']"));
        private static WebElements SaveEditButton() => new(By.XPath("//*[@name='SaveEdit']"));
        private static WebElements MenuItemButton() => new(By.XPath("//*[contains(@class, 'menu-button')]//button"));
        private static WebElements DeleteItemButton() => new(By.XPath("//*[@apiname='Delete']"));
        private static WebElements EditItemButton() => new(By.XPath("//*[@apiname='Edit']"));
        private static WebElements ConfirmDeleteButton() => new(By.XPath("//button[@title='Delete']"));
        public static void SaveEdit() => SaveEditButton().Click();
        public static void CreateNewItem() => NewItemButton().Click();
        public static void DeleteItem()
        {
            MenuItemButton().Click();
            DeleteItemButton().Click();
            ConfirmDeleteButton().Click();
        }

        public static void EditItem()
        {
            MenuItemButton().Click();
            EditItemButton().Click();
        }
    }
}
