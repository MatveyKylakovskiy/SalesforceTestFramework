using RestSharp;

namespace SalesforceTestFramework.API.ApiMethotds
{
    public class MethodDELETE : BaseMethod
    {
        public void SendDeleteMethod(string resource, RestClient client)
        {
            CreateRequest(resource, Method.Delete);
            CreateResponse(client);
        }
    }
}
