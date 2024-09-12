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

        public static bool IsContactCreated(string firstName, string lastName) => WebElements.IsElementDisplayed(By.XPath($"//*[@slot='primaryField' and text()='{firstName} {lastName}']"));
    }
}
