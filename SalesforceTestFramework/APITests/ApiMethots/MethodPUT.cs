
using RestSharp;

namespace SalesforceTestFramework.API.ApiMethotds
{
    public class MethodPUT : BaseMethod
    {
        public void SendPutMethod<T>(string resource, RestClient client, T jsonReq) where T : class
        {
            CreateRequest(resource, Method.Put);
            _request.AddJsonBody(jsonReq);
            CreateResponse(client);
        }
    }
}
