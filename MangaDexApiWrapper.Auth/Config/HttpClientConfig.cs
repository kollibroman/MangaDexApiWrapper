
namespace MangaDexApiWrapper.Auth.Config
{
    public class HttpClientConfig
    {
        public const string _baseUri = "https://api.mangadex.org";
        public const string _authUri = "https://api.mangadex.org/auth/login";
        public const string _authChecknUri = "https://api.mangadex.org/auth/check";
        public const string _logoutUri = "https://api.mangadex.org/auth/logout";
        public const string _refreshUri = "https://api.mangadex.org/auth/refresh";

        public Uri BaseUrl { get => new Uri(_baseUri); }
        public Uri AuthUrl { get => new Uri(_authUri); }
        public Uri AuthCheckUrl { get => new Uri(_authChecknUri); }
        public Uri LogoutUrl { get => new Uri(_logoutUri); }
        public Uri RefreshUrl { get => new Uri(_refreshUri); }
    }
}