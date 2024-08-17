using OpenQA.Selenium;
using SalesforceTestFramework.AppSettings.AppSettingsUI;
using SalesforceTestFramework.UI.Pages;
using System.Collections;

namespace SalesforceTestFramework.Helpers
{
    public class TestDataUI
    {
        public class LoginData : IEnumerable
        {

            

            public SettingsUI settingsUI = new();
            public IEnumerator GetEnumerator()
            {
                //yield return new object[] { settingsUI.Login, settingsUI.Password, By.XPath(LoginPage.HomeButtonXpath) };

                // yield return new object[] { "", settingsUI.Password, By.XPath(LoginPage.LogoIconXpath) };

                // yield return new object[] { settingsUI.Login, "", By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { "", "", By.XPath(LoginPage.LogoIconXpath)};

                //yield return new object[] { RandomData.RandomString(8), "", By.XPath(LoginPage.ErrorMesageXpath) };
                yield return new object[] { RandomData.RandomString(9), "", By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { settingsUI.Login, RandomData.RandomString(8), By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { RandomData.RandomString(8), settingsUI.Password, By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { settingsUI.Password, settingsUI.Login, By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { "SELECT id, login FROM users WHERE login = “;” OR 1=1 LIMIT 0,1; – and password" +
                //  " = hash(“;Some password”)", settingsUI.Login, By.XPath(LoginPage.ErrorMesageXpath) };

                // yield return new object[] { "https://qatech5-dev-ed.develop.my.salesforce.com/users/?id=1 AND 1=0  " +
                //  "UNION  SELECT  1,concat(login,password), 3,4,5,6  FROM  users WHERE id =1; --", settingsUI.Login, By.XPath(LoginPage.ErrorMesageXpath) };


            }
        }

        public class LoginData2
        {
            static object[] LoginData = {
                new object[] {"", By.XPath(LoginPage.ErrorMesageXpath) },
                new object[] {"", By.XPath(LoginPage.ErrorMesageXpath) },
                new object[] {"", By.XPath(LoginPage.ErrorMesageXpath) },
                new object[] {"", By.XPath(LoginPage.ErrorMesageXpath) }
            };
        }
    }
}
