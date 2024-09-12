using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.CreateCaseFields
{
    public class StatusField : BaseField
    {
        public StatusField()
        {
            inputFieldLocator = "Satus";
        }

        private WebElements StatusValue(string value) => new(By.XPath($"//*[@data-value='{value}']"));

        private WebElements StatusFieldButton() => new(By.XPath("//*[@aria-label='Status' and @role='combobox']"));
        public void SelectNew()
        {
            StatusFieldButton().Click();
            StatusValue("New");
        }
        public void SelectWorking()
        {
            StatusFieldButton().Click();
            StatusValue("Working").Click();
        }
        public void SelectEscalated()
        {
            StatusFieldButton().Click();
            StatusValue("Escalated").Click();
        }
    }
}
