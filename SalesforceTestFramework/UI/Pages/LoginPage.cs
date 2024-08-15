using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages
{
    public class LoginPage
    {
        private static WebElements Login() => new(By.Id("username"));
        private static WebElements Password() => new(By.Id("password"));
        private static WebElements LoginButton() => new(By.Id("Login"));
        private static WebElements HomeButton() => new(By.XPath("//span[@class='title slds-truncate' and text()='Home']"));

        public static void Login(string username, string password)
        {
            Login().SendValue(username);
            Password().SendValue(password);
            LoginButton().Click();
        }

        public static bool IsHomeButtonExist() => HomeButton().IsElementDisplayed();
    }
}
