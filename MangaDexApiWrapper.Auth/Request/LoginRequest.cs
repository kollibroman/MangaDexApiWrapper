namespace MangaDexApiWrapper.Auth.Request
{
    public class LoginRequest
    {
        public LoginRequest(string userName, string _password)
        {
            username = userName;
            password = _password;
        }

        public string username { get; set; }
        public string password { get; set; }
    }
}