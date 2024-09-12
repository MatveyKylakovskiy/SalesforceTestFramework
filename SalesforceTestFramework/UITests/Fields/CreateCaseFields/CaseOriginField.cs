
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Fields.CreateCaseFields
{
    public class CaseOriginField : BaseField
    {
        public CaseOriginField()
        {
            inputFieldLocator = "Case Origin";
        }

        private WebElements CaseOriginFieldButton() => new(By.XPath($"//*[@aria-label='{inputFieldLocator}' and @role='combobox']"));

        private WebElements CaseOriginValue(string value) => new(By.XPath($"//*[@data-value='{value}']"));

        public void SelectPhone()
        {
            CaseOriginFieldButton().Click();
            CaseOriginValue("Phone").Click();
        }

        public void SelectEmail()
        {
            CaseOriginFieldButton().Click();
            CaseOriginValue("Email").Click();
        }

        public void SelectWeb()
        {
            CaseOriginFieldButton().Click();
            CaseOriginValue("Web").Click();
        }
    }

}
