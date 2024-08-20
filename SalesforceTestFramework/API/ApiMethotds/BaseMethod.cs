using Newtonsoft.Json;
using RestSharp;

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

        public T ReturnJsonContent<T>()
        {
            return JsonConvert.DeserializeObject<T>(_response.Content);
        }
        
        public int ReturnStatusCode()
        {
            return (int)_response.StatusCode;
        }

        public string ReturnToken()
        {

        }
    }
}
