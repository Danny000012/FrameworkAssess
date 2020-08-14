using System.Collections.Generic;
using System.IO;
using System.Linq;
using Framework.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Framework.Services
{
    public class API<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "https://jsonplaceholder.typicode.com/";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var restClient = new RestClient(url);
            return restClient;
        }

        public RestRequest CreatePostRequest(string newUser)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", newUser, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public IRestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        public List<Root> GetContent(string response)
        {
            var myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(response);
            return myDeserializedClass;
        }
    }
}