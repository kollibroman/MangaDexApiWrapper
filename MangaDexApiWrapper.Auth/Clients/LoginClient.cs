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
        private LoginResponse? _loginResponse;
        private LoginResponse? LoginResponse { get => _loginResponse; }


        public LoginClient(HttpClientConfig config)
        {
            _config = config;
        }

        public LoginClient()
        {
            _config = new HttpClientConfig();
        }

        public async Task<LoginResponse> LoginPostRequestAsync(string Username, string password)
        {
            var Request = new LoginRequest(Username, password);
            var SerializedRequest = JsonConvert.SerializeObject(Request);

            
           using(var httpClient = new HttpClient())
           {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, _config.AuthUri);
                requestMessage.Content = new StringContent(SerializedRequest, Encoding.UTF8, "application/json");

                var responseString = await httpClient.SendAsync(requestMessage);
                var Response = await responseString.Content.ReadAsStringAsync();
                

                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(Response);

                _loginResponse = loginResponse;

                return loginResponse;
           } 
        }
       

        public async Task<CheckResponse> CheckTokenAsync()
        {
            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = _config.AuthCheckUri;
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bearer",$"{LoginResponse.Token.Session}");

                var response = await httpClient.GetAsync(httpClient.BaseAddress);
                var responseMsg = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseMsg);

                var checkResponse = JsonConvert.DeserializeObject<CheckResponse>(responseMsg);
                return checkResponse;
            }
       }

       public async Task<LoginResponse> RefreshAsync()
       {
            var request = new RefreshRequest(LoginResponse.Token.Session);
            var SerializedRequest = JsonConvert.SerializeObject(request);

            using(var httpClient = new HttpClient())
            {
                HttpRequestMessage requestMessage = new(HttpMethod.Post, _config.RefreshUri);
                requestMessage.Content = new StringContent(SerializedRequest, Encoding.UTF8, "application/json");

                var responseString = await httpClient.SendAsync(requestMessage);
                var Response = await responseString.Content.ReadAsStringAsync();

                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(Response);

                _loginResponse = loginResponse;
                return loginResponse;
            }
       }
    }
}