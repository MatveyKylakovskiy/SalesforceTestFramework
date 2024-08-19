using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesforceTestFramework.UI.Pages
{
    public class LoginPage
    {
        private static WebElements Login() => new(By.Id("username"));
        private static WebElements Password() => new(By.Id("password"));
        private static WebElements LoginButton() => new(By.Id("Login"));

        public static void Login(string username, string password)
        {
            Login().SendValue(username);
            Password().SendValue(password);
            LoginButton().Click();
        }
    }
}
