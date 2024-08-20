using Newtonsoft.Json;
using RestSharp;
using SalesforceTestFramework.API.ApiMethotds;
using SalesforceTestFramework.API.APIModels.Models.Response;
using SalesforceTestFramework.Helpers;

namespace SalesforceTestFramework.API.APITests
{
    public class Tests : BaseAPITest
    {
        [Description("CreateAccountTest")]
        [Test]
        public void CreateAccountTest()
        {
            var accountName = RandomData.RandomString(8);
            var accessToken = BaseMethod.ReturnToken(client, settingsAPI);
            var request = new RestRequest("services/data/v43.0/sobjects/Account", Method.Post);

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            var accountData = new
            {
                attributes = new { type = "Account" },
                Name = accountName
            };

            request.AddJsonBody(accountData);

            var response = client.Execute(request);

            AccountResponse accountResponse = JsonConvert.DeserializeObject<AccountResponse>(response.Content);

            Assert.That(accountResponse.Success, Is.True);
        }

        [Description("DeleteAccountTest")]
        [Test]
        public void DeleteAccountTest()
        {
            var accountName = RandomData.RandomString(8);
            var accessToken = BaseMethod.ReturnToken(client, settingsAPI);
            var request = new RestRequest("services/data/v43.0/sobjects/Account", Method.Post);

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            var accountData = new
            {
                attributes = new { type = "Account" },
                Name = accountName
            };

            request.AddJsonBody(accountData);

            var response = client.Execute(request);

            AccountResponse accountResponse = JsonConvert.DeserializeObject<AccountResponse>(response.Content);

            var accountId = accountResponse.Id;

            Assert.That(accountResponse.Success, Is.True);

            request = new RestRequest($"services/data/v43.0/sobjects/Account/{accountId}", Method.Delete);
            response = client.Execute(request);
            request = new RestRequest($"services/data/v43.0/sobjects/Account/{accountId}", Method.Get);
            response = client.Execute(request);

            List<ErrorResponse> errors = JsonConvert.DeserializeObject<List<ErrorResponse>>(response.Content);

            Assert.That(errors[0].Message, Is.EqualTo("The requested resource does not exist"));
        }
    }
}