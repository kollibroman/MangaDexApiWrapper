using MangaDexApiWrapper.Auth.EntityModels;

namespace MangaDexApiWrapper.Auth.Response
{
    public class LoginResponse
    {
        public Result Result { get; set; }
        public Token Token { get; set; }
        public string Message { get; set; }
    }
}