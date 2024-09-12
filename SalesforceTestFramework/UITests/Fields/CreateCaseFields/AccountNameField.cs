using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.CreateCaseFields
{
    public class AccountNameField : BaseField
    {
        private WebElements InputField() => new(By.XPath($"//*[@placeholder='Search Accounts...']"));

        private static WebElements SelectAccount(string accountName) => new(By.XPath($"//span[@class='slds-truncate' and text()='{accountName}']"));

        public void InputDataToField(string accountName)
        {
            InputField().Click();
            SelectAccount(accountName).Click();
        }
    }
}
