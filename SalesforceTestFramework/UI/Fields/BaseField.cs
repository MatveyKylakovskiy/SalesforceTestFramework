using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields
{
    public class BaseField
    {
        protected string? inputFieldLocator { get; init; }
        protected virtual WebElements InputField() => new(By.XPath($"//*[text()='{inputFieldLocator}']/following-sibling::*/child::*"));
        public void InputDataToField(string data)
        {
            InputField().Clear();
            InputField().SendValue(data);
        }

        public void SelectField() => InputField().Click();      
    }
}
