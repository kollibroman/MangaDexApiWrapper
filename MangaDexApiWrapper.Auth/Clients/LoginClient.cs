using System.Net.Http.Headers;
using System.Text;
using MangaDexApiWrapper.Auth.Config;
using MangaDexApiWrapper.Auth.Request;
using MangaDexApiWrapper.Auth.Response;
using Newtonsoft.Json;

namespace MangaDexApiWrapper.Auth.Clients
{
    public class LoginClient
    {
        private readonly HttpClientConfig _config;

        private LoginResponse LoginResponse { get; set; }

        public LoginClient(HttpClientConfig config)
        {
            _config = config;
        }

        public LoginClient()
        {
            _config = new HttpClientConfig();
        }

        public async Task<LoginResponse> LoginPostRequest(string Username, string password)
        {
            var Request = new LoginRequest(Username, password);
            var SerializedRequest = JsonConvert.SerializeObject(Request);

            Console.WriteLine(SerializedRequest);
            
           using(var httpClient = new HttpClient())
           {
                httpClient.BaseAddress = _config.AuthUrl;
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, _config.AuthUrl);
                requestMessage.Content = new StringContent(SerializedRequest, Encoding.UTF8, "application/json");

                var responseString = await httpClient.SendAsync(requestMessage);
                var Response = await responseString.Content.ReadAsStringAsync();
                

                var loginresponse = JsonConvert.DeserializeObject<LoginResponse>(Response);

                LoginResponse = loginresponse;

                return loginresponse;
           } 
        }

        // public async Task<CheckResponse> CheckToken()
        // {
        //     using(var httpClient = new HttpClient())
        //     {
        //         httpClient.BaseAddress = _config.AuthCheckUrl;
        //         httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bearer",$"{LoginResponse.Token}");

        //         var response = await httpClient.GetAsync(httpClient.BaseAddress);
        //         var responseMsg = await response.Content.ReadAsStringAsync();

        //         Console.WriteLine(responseMsg);

        //         var checkResponse = JsonConvert.DeserializeObject<CheckResponse>(responseMsg);
        //         return checkResponse;
        //     }
       // }
    }
}