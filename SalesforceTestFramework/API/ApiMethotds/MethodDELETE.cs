
using RestSharp;

namespace HomeWork30APITest.ApiTests.ApiMethotds
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
