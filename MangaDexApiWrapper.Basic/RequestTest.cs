using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace MangaDexApiWrapper.Basic
{
    public class RequestTest
    {
        public async Task test()
        {
            IRestClient client = new RestClient { BaseUrl = new Uri("https://api.mangadex.org") };
            IRestRequest request = new RestRequest();
            IRestResponse response = client.Get(request);

           if(response.StatusCode != HttpStatusCode.OK)
           {
               Console.WriteLine(response.StatusCode);
               Console.WriteLine(response.ErrorMessage);
           }

           else
           {
               Console.WriteLine(response.StatusCode);
           }

           await Task.CompletedTask;
        }
    }
}