using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SalesforceTestFramework.UI.Pages
{
    public class ReportsPage
    {
        private static WebElements IFrame() => new(By.XPath("//iframe[@title='Report Builder']"));
        private static WebElements DropdownButton() => new(By.XPath("//td//div[contains(@class, 'slds-dropdown')]//button"));
        private static WebElements StartReportButton() => new(By.XPath("//*[@role='menuitem' and @data-index='1']"));
        private static WebElements SaveAndRunButton() => new(By.XPath("//*[text()='Save & Run']"));
        private static WebElements ReportNameField() => new(By.XPath("//*[@id='reportName']"));
        public static void CreateReport()
        {   
            IFrame().SwitchToFrame();
            DropdownButton().Click();
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
    }
}