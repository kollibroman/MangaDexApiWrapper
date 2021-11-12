using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace MangaDexApiWrapper.Basic.RequestExtensions
{
    public class Post
    {
        public async Task<IRestResponse> PostAync(string url, object body)
        {
            var client = new RestClient(url);
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddJsonBody(body);

            var response = await client.ExecuteAsync(request);
            return response;
        }
    }
}