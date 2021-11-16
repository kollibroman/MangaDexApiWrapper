namespace MangaDexApiWrapper.Basic.Auth
{
    public class BasicAuthenticator
    {
        public async Task ClassicLogin()
        {
            IRestClient client = new RestClient("https://api.mangadex.org");
            
            IRestRequest request = new RestRequest("/auth/login", Method.POST);
            // var content = new Dictionary<string, string>
            // {
            //     {"username:", "KollibroMan"},
            //     {"password:", "Miau8888"}
            // };
            // var requestContent = JsonConvert.SerializeObject(content);
            // request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);
            // request.AddJsonBody(requestContent);

            request.AddQueryParameter("username", "KollibroMan");
            request.AddQueryParameter("email", "filipkwiek888@gmail.com");
            request.AddQueryParameter("password", "Miau8888");

            IRestResponse response = await client.ExecuteAsync(request);
            
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(request.Parameters);
        }
    }
}