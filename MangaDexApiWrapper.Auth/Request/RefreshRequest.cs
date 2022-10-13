
namespace MangaDexApiWrapper.Auth.Request
{
    public class RefreshRequest
    {
        public RefreshRequest(string TokenSession)
        {
            Token = TokenSession;
        }
        public string Token { get; set; }
    }
}