using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.EditAccountFields
{
    public class WebSiteField : BaseField
    {
        public WebSiteField()
        {
            inputFieldLocator = "Website";
        }
        private WebElements InputField() => new(By.XPath($"//input[@name='{inputFieldLocator}']"));
        public void InputDataToField(string data)
        {
            InputField().SendValue(data);
        }
    }
}
