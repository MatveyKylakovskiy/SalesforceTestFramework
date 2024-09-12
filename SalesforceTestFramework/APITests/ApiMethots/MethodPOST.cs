using Newtonsoft.Json;
using RestSharp;

namespace SalesforceTestFramework.API.ApiMethotds
{
    public class MethodPOST : BaseMethod
    {
        public void SendPostMethod<T>(string resource, RestClient client, T jsonReq) where T : class
        {
            CreateRequest(resource, Method.Post);
            var jsonBody = JsonConvert.SerializeObject(jsonReq);
            _request.AddJsonBody(jsonBody);
            CreateResponse(client);
        }

    }
}
