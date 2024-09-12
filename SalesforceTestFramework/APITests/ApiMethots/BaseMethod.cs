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