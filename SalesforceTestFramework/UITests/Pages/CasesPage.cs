using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesforceTestFramework.UI.Fields.CreateCaseFields;

namespace SalesforceTestFramework.UI.Pages
{
    public class CasesPage
    {
        public static StatusField StatusField = new();
        public static AccountNameField AccountNameField = new();
        public static CaseOriginField CaseOriginField = new();
        public static ContactNameField ContactNameField = new();
        public static SubjectField SubjectField = new();

        public static bool IsCaseCreated(string subjectName) => WebElements.IsElementDisplayed(By.XPath($"//*[text()='{subjectName}']"));
    }
}
