
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.EditAccountFields
{
    public class DescriptionEditEditField :BaseField
    {
        public DescriptionEditEditField()
        {
            inputFieldLocator = "//label[text()='Description']/following::div//textarea";
        }

        private WebElements InputField() => new(By.XPath($"{inputFieldLocator}"));
        public void InputDataToField(string data)
        {
            InputField().SendValue(data);
        }
    }
}
