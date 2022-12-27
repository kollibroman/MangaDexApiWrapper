
namespace MangaDexApiWrapper.Auth.Config
{
    public class HttpClientConfig
    {
        public const string _authUri = "https://api.mangadex.org/auth/login";
        public const string _authCheckUri = "https://api.mangadex.org/auth/check";
        public const string _logoutUri = "https://api.mangadex.org/auth/logout";
        public const string _refreshUri = "https://api.mangadex.org/auth/refresh";

        public Uri AuthUri { get => new Uri(_authUri); }
        public Uri AuthCheckUri { get => new Uri(_authCheckUri); }
        public Uri LogoutUri { get => new Uri(_logoutUri); }
        public Uri RefreshUri { get => new Uri(_refreshUri); }
    }
}