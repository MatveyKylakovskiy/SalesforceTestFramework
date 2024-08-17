using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages.Fields
{
    public class BaseField
    {
        protected string? inputFieldLocator { get; init; }
        private WebElements InputField() => new(By.XPath($"//*[text()='{inputFieldLocator}']/following-sibling::*/child::*"));
        public void InputDataToField(string data)
        {
            InputField().Clear();
            InputField().SendValue(data);
        }
    }
}
