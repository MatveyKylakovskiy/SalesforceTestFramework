using HomeWork30APITest.ApiTests.ApiMethotds;
using RestSharp;

namespace SalesforceTestFramework.API.APITests
{
    public class BaseAPITest
    {
        private const string BaseUrl = "https://reqres.in/api/";
        public RestClient client;

        [SetUp]
        public void Setup()
        {
            client = new RestClient(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            client.Dispose();
        }
    }
}
