using Newtonsoft.Json;
using RestSharp;
using SalesforceTestFramework.API.APIModels.Models.Response;
using SalesforceTestFramework.AppSettings.AppSettingsAPI;

namespace SalesforceTestFramework.API.ApiMethotds
{
    public abstract class BaseMethod
    {
        public  RestRequest _request;
        public  RestResponse _response;

        private protected BaseMethod CreateRequest(string recource, Method method)
        {
            _request = new RestRequest(recource, method);
            return this;
        }

        private protected RestResponse CreateResponse(RestClient client)
        {
            return _response = client.Execute(_request);

        }

        protected T ReturnJsonContent<T>()
        {
            return JsonConvert.DeserializeObject<T>(_response.Content);
        }

        public int ReturnStatusCode()
        {
            return (int)_response.StatusCode;
        }
        
        public static string ReturnToken(RestClient client, SettingsAPI settingsAPI)
        {
            var request = new RestRequest("services/oauth2/token", Method.Post);

            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", settingsAPI.Key);
            request.AddParameter("client_secret", settingsAPI.Secret);

            var response = client.Execute(request);

            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);

            return tokenResponse.Access_token;
        }
    }
}

/*public static string ReturnToken(RestClient client,)
{
    var client = new RestClient("https://qatech5-dev-ed.develop.my.salesforce.com");

    // Создание запроса
    var request = new RestRequest("services/oauth2/token", Method.Post);

    request.AddParameter("grant_type", "client_credentials");
    request.AddParameter("client_id", "3MVG91oqviqJKoEGKRXLsL77MnFTAHL8OQfGcQewJk1upCv4mlRgcTR4RGOVctDULuXRZGF7iiAAxP6uk5AUa");
    request.AddParameter("client_secret", "5564849790A400E23EEE0D59804CDF69B25D9A457D60C38DA7E63585875E63A6");

    // Выполнение запроса
    var response = client.Execute(request);

    TokenResponse tokenResponse = ReturnJsonContent2<TokenResponse>(response);

    return tokenResponse.Access_token;
}*/