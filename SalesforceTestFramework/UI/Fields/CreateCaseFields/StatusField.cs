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

        private WebElements TargetField() => new(By.XPath("//*[@aria-label='Status' and @role='combobox']"));
        public void SelectNew()
        {
            TargetField().Click();
            StatusValue("New");
        }
        public void SelectWorking()
        {
            TargetField().Click();
            StatusValue("Working").Click();
        }
        public void SelectEscalated() => StatusValue("Escalated");
    }
}
