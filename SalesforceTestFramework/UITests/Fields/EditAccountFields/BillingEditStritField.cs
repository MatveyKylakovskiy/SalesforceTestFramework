
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.EditAccountFields
{
    public class BillingEditStritField : BaseField
    {
        public BillingEditStritField()
        {
            inputFieldLocator = "//label[text()='Billing Street']/following::div//textarea";
        }

        private WebElements InputField() => new(By.XPath($"//textarea[@name='street']"));
        public void InputDataToField(string data)
        {
            InputField().SendValue(data);
        }
    }
}
