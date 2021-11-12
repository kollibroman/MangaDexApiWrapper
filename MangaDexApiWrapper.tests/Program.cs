using System;
using System.Threading.Tasks;
using MangaDexApiWrapper.Basic.Auth;

namespace MangaDexApiWrapper.tests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var auth = new BasicAuthenticator();

            await auth.ClassicLogin("KollibroMan", "Miau8888");
        }
    }
}
