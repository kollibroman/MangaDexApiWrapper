using System.Text;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using MangaDexApiWrapper.Basic.RequestExtensions;
using System.Net.Http;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;

namespace MangaDexApiWrapper.Basic.Auth
{
    public class BasicAuthenticator
    {
        public async Task ClassicLogin(string login, string passwd)
        {
            Post post = new Post();
            IRestClient client = new RestClient { BaseUrl = new Uri("https://api.mangadex.org/auth/login") };
            client.UseNewtonsoftJson();

            var RequestData = new Dictionary<string, string>
            {
                {"username", login},
                {"password", passwd}
            };
            var JsonData = JsonConvert.SerializeObject(RequestData);
            var contentData = new StringContent(JsonData, Encoding.UTF8);

            var response = await post.PostAync(client.BaseUrl.ToString(), contentData);
            
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(response.ErrorMessage);
                Console.WriteLine(response.ErrorException);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
        }
    }
}