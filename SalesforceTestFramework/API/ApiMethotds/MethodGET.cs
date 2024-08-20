
using RestSharp;

namespace SalesforceTestFramework.API.ApiMethotds
{
    public class MethodGET : BaseMethod
    {
        public void SendGetMethod(string resource, RestClient client)
        {
            CreateRequest(resource, Method.Get);
            CreateResponse(client);
        }

    }
}
