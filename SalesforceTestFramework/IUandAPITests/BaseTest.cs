

using PageObjectLib.Factories;
using RestSharp;
using SalesforceTestFramework.AppSettings.AppSettingsAPI;
using SalesforceTestFramework.AppSettings.AppSettingsUI;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.IUandAPI
{
    public class BaseTest
    {
        public SettingsUI settingsUI;
        public SettingsAPI settingsAPI;
        public RestClient client;

        [SetUp]
        public void Setup()
        {
            settingsUI = new SettingsUI();

            settingsAPI = new SettingsAPI();
            client = new RestClient(settingsAPI.MyDomain);

            Driver.CreateDriver(settingsUI.Driver);
            Driver.GoUrl(settingsUI.URL);
            LoginPage.Login(settingsUI.Login, settingsUI.Password);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
            client.Dispose();
        }
    }
}
