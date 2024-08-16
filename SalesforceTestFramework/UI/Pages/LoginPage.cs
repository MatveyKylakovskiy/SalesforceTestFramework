using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SalesforceTestFramework.UI.Pages
{
    public class LoginPage
    {
        private static WebElements Login() => new(By.Id("username"));
        private static WebElements Password() => new(By.Id("password"));
        private static WebElements LoginButton() => new(By.Id("Login"));

        public static readonly string HomeButtonXpath = "//span[@class='title slds-truncate' and text()='Home']";
        public static readonly string LogoIconXpath = "//*[@id='logo']";
        public static readonly string ErrorMesageXpath = "//*[@id='error']";

        public static void Login(string username, string password)
        {
            Login().SendValue(username);
            Password().SendValue(password);
            LoginButton().Click();
        }

        public static bool IsElementExist(By locator) => WebElements.IsElementDisplayed(locator);

    }
}
