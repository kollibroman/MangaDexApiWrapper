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
            var client = new RestClient("https://api.mangadex.org/");

            client.Authenticator = new SimpleAuthenticator("username", login, "password", passwd);
            var request = new RestRequest("auth/login", Method.GET);

            var response = await client.ExecuteAsync(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("login succesfull");
            }

            else
            {
                Console.WriteLine("DUPA");
            }
        }
    }
}