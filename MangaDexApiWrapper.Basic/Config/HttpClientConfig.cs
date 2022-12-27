namespace MangaDexApiWrapper.Basic.Config
{
    public class HttpClientConfig
    {
        static readonly string _baseUri = "https://api.mangadex.org";
        static readonly string _mangaUri = "https://api.mangadex.org/manga";
        static readonly string _mangaVolumesAndChaptersUri = "https://api.mangadex.org/manga/{id}/aggregate";
        static readonly string _specifiedMangaUri  = "https://api.mangadex.org/manga/{id}";
        static readonly string _mangaInCustomListUri = "https://api.mangadex.org/manga/{id}/list/{listId}";
        static readonly string _followMangaUri = "https://api.mangadex.org/manga/{id}/follow";
        static readonly string _mangaFeedUri = "https://api.mangadex.org/{id}/feed";
        static readonly string _mangaIdReadMarker = "https://api.mangadex.org/manga/{id}/read";
        static readonly string _mangaReadMarkers = "https://api.mangadex.org/manga/read";
        static readonly string _randomManga = "https://api.mangadex.org/manga/random";
        static readonly string _tagList = "https://api.mangadex.org/manga/tag";
        static readonly string _mangaStatus = "https://api.mangadex.org/manga/status";
        static readonly string _mangaIdStatus = "https://api.mangadex.org/manga/{id}/status";
        static readonly string _mangaDraft = "https://api.mangadex.org/manga/draft/{id}";
        static readonly string _submitMangaDraft = "https://api.mangadex.org/manga/draft/{id}/commit";
        static readonly string _mangaDrafts = "https://api.mangadex.org/manga/draft";
        static readonly string _mangaRelations = "https://api.mangadex.org/manga/{id}/relation";
        static readonly string _mangaRelationId = "https://api.mangadex.org/manga/{MangaId}/relation/{id}";

        public Uri BaseUri { get => new Uri(_baseUri); }
        public Uri MangaUri { get => new Uri(_mangaUri); }
        public Uri MangaValumesAndChapetrsUri { get => new Uri(_mangaVolumesAndChaptersUri); }
        public Uri SpecifiedMangaUri { get => new Uri(_specifiedMangaUri); }
        public Uri MangaInCustomListUri { get => new Uri(_mangaInCustomListUri); }
        public Uri FollowMangaUri { get => new Uri(_followMangaUri); }
        public Uri MangaFeedUri { get => new Uri(_mangaFeedUri); }
        public Uri MangaIdReadMarkerUri { get => new Uri(_mangaIdReadMarker); }
        public Uri MangaReadMarkersUri { get => new Uri(_mangaReadMarkers); }
        public Uri RandomMangaUri { get => new Uri(_randomManga); }
        public Uri TagListUri { get => new Uri(_tagList); }
        public Uri MangaStatusUri { get => new Uri(_mangaStatus); }
        public Uri MangaIdStatusUri { get => new Uri(_mangaIdStatus); }
        public Uri MangaDraftUri { get => new Uri(_mangaDraft); }
        public Uri SubmitMangaDraftUri { get => new Uri(_submitMangaDraft); }
        public Uri MangaDraftsUri { get => new Uri(_mangaDrafts); }
        public Uri MangaRelationsUri { get => new Uri(_mangaRelations); }
        public Uri MangaRelationIdUri { get => new Uri(_mangaRelationId); }
    }
}