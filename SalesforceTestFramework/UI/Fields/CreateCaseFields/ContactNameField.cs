using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.CreateCaseFields
{
    public class ContactNameField : BaseField
    {
        private WebElements InputField() => new(By.XPath($"//*[@placeholder='Search Contacts...']"));

        private static WebElements SelectAccount(string contactName) => new(By.XPath($"//span[@class='slds-truncate' and text()='{contactName}']"));

        public void InputDataToField(string contactName)
        {
            InputField().Click();
            SelectAccount(contactName).Click();
        }
    }
}
