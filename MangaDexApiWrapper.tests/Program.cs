using System;
using System.Threading.Tasks;
using MangaDexApiWrapper.Basic.Auth;
using MangaDexApiWrapper.Basic;

namespace MangaDexApiWrapper.tests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var auth = new BasicAuthenticator();
            var test = new RequestTest();

            await auth.ClassicLogin("KollibroMan", "Miau8888");
            // await test.test(); 
        }
    }
}
