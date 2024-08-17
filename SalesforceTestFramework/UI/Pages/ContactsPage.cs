using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesforceTestFramework.UI.Fields.CreateContactFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class ContactsPage
    {
        public static AccountNameField AccountNameField = new();
        public static FirstNameField FirstNameField = new();
        public static LastNameField LastNameField = new();

        public static bool IsContactCreated(string contactName) => WebElements.IsElementDisplayed(By.XPath($"//*[@slot='primaryField' and text()='{contactName}']"));
    }
}
