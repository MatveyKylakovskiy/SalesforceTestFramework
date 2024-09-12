using RestSharp;
using SalesforceTestFramework.AppSettings.AppSettingsAPI;

namespace SalesforceTestFramework.API.APITests
{
    public class BaseAPITest
    {
        public RestClient client;
        public SettingsAPI settingsAPI;

        [SetUp]
        public void Setup()
        {
            settingsAPI = new SettingsAPI();
            client = new RestClient(settingsAPI.MyDomain);
        }

        [TearDown]
        public void TearDown()
        {
            client.Dispose();
        }
    }
}
