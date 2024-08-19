
using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.UI.Fields.EditAccountFields
{
    public class PhoneField : BaseField
    {
        public PhoneField()
        {
            inputFieldLocator = "Phone";
        }
        private WebElements InputField() => new(By.XPath($"//*[@name='{inputFieldLocator}']"));

        public void InputDataToField(string data)
        {
            var strLength = OneAccountPage.GetPhoneNumber().Length;

            while (strLength != 0)
            {
                InputField().SendValue(Keys.Backspace);
                strLength--;
            }

            InputField().SendValue(data);
        }
    }
}
