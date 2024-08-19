using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages
{
    public class ReportsPage
    {
        private static WebElements IFrameReportBuilder() => new(By.XPath("//iframe[@title='Report Builder']"));
        private static WebElements IFrameReportViewer() => new(By.XPath("//iframe[@title='Report Viewer']"));
        private static WebElements StartReportButton() => new(By.XPath("//*[@role='menuitem' and @data-index='1']"));
        private static WebElements SaveAndRunButton() => new(By.XPath("//*[text()='Save & Run']"));
        private static WebElements ReportNameField() => new(By.XPath("//*[@id='reportName']"));
        private static WebElements SaveReportButton() => new(By.XPath("//footer//button[text()='Save']"));
        private static WebElements CreatedReportName() => new(By.XPath("//span[contains(@class, 'slds-page')]"));
        public static void CreateReport(string reportName)
        {
            IFrameReportBuilder().SwitchToFrame();
            SelectReport(reportName);
            StartReportButton().Click();
            SaveAndRunButton().Click();
        }

        public static void RenameReport(string newReportName)
        {
            var strLength = ReportNameField().GetAttribute("value").Length;

            while (strLength != 0)
            {
                ReportNameField().SendValue(Keys.Backspace);
                strLength--;
            }

            ReportNameField().SendValue(newReportName);
        }

        public static void SaveReport() => SaveReportButton().Click();

        public static bool IsReportCreated(string reportName)
        {
            IFrameReportBuilder().FrameExit();
            IFrameReportViewer().SwitchToFrame();
            return reportName == CreatedReportName().GetAttribute("title");
        }

        private static WebElements ReportsTypeName() => new(By.XPath("//p[@class='slds-truncate' and @data-tooltip]"));
        private static WebElements DropDownButtons() => new(By.XPath("//td//div[contains(@class, 'slds-dropdown')]//button"));
        private static List<string> KeysToDic() => ReportsTypeName().ListOfElements().Select(n => n.Text).ToList();
        private static List<IWebElement> ValuesToDic() => DropDownButtons().ListOfElements();

        private static Dictionary<string, IWebElement> GetReportsTypes()
        {
            return KeysToDic().Select((key, index) => new { Key = key, Value = ValuesToDic()[index] }).ToDictionary(x => x.Key, x => x.Value);
        }

        private static void SelectReport(string reportName)
        {
            GetReportsTypes()[reportName].Click();
        }
    }
}