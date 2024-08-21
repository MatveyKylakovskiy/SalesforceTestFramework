using Newtonsoft.Json;
using RestSharp;
using SalesforceTestFramework.API.ApiMethotds;
using SalesforceTestFramework.API.APIModels.Models.Response;
using SalesforceTestFramework.AppSettings.AppSettingsAPI;
using SalesforceTestFramework.Helpers;
using SalesforceTestFramework.UI.Pages;

namespace SalesforceTestFramework.IUandAPI
{ public class UIandAPiTests : BaseTest
    {
        [Test]
        public void UIandAPICreate()
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

            HomePage.MoveToAccountsPage();

            Assert.That(AccountsPage.IsAccountCreated(accountName), Is.True);
        }
    }
}