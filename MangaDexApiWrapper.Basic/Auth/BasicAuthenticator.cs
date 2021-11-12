using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace MangaDexApiWrapper.Basic.Auth
{
    public class BasicAuthenticator
    {
        public async Task ClassicLogin(string login, string passwd)
        {
            IRestClient client = new RestClient { BaseUrl = new Uri("https://api.mangadex.org") };

            client.Authenticator = new HttpBasicAuthenticator(login, passwd);
            IRestRequest request = new RestRequest("/auth/login", Method.POST);
            
            IRestResponse response = await client.ExecutePostAsync(request);
            
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