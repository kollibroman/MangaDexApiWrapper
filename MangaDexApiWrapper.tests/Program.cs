using System;
using System.IO;
using System.Threading.Tasks;
using MangaDexApiWrapper.Auth.Clients;
using MangaDexApiWrapper.Basic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MangaDexApiWrapper.tests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var LoginClient = new LoginClient();

            //await LoginClient.LoginPostRequestAsync("KollibroMan", "Miau8888");
            await LoginClient.CheckTokenAsync();
        }
    }
}
