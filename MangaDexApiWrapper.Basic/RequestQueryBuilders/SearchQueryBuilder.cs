using System;
using MangaDexApiWrapper.Basic.Config;
using MangaDexApiWrapper.Basic.Interfaces;
using Microsoft.AspNetCore.WebUtilities;

namespace MangaDexApiWrapper.Basic.RequestQueryBuilders
{
    public class SearchQueryBuilder : ISearchQueryBuilder
    {
        private readonly HttpClientConfig _config;

        public SearchQueryBuilder(HttpClientConfig config)
        {
            _config = config;
        }

        public Uri BasicSearch(string title)
        {
            var req_dict = new Dictionary<string, string>()
            {
                {"title", title}
            };

            return new Uri(QueryHelpers.AddQueryString(_config.MangaUri.ToString(), req_dict));
        }

        public Uri TagSearch(string[] includedTag_ids, string[] excludedTag_ids)
        {
            var req_dict = new Dictionary<string, string>()
            {
                {"includedTags[]", String.Join(",", includedTag_ids)},
                {"excludedTags[]", String.Join(",", excludedTag_ids)}
            };

            return new Uri(QueryHelpers.AddQueryString(_config.MangaUri.ToString(),req_dict));
        }

        public Uri TagSearchWithOrder(string[] includedTag_ids, string[] excludedTag_ids, string order, string followedCount)
        {
            var req_dict = new Dictionary<string, string>()
            {
                {"includedTags[]", String.Join(",", includedTag_ids)},
                {"excludedTags[]", String.Join(",", excludedTag_ids)},
                {"rating", order},
                {"followedCount", followedCount}
            };

            return new Uri(QueryHelpers.AddQueryString(_config.MangaUri.ToString(),req_dict));
        }

        public Uri DemographicOrContentRating(string[] publicationDemographic, string[] status, string[] contentRating)
        {
            var req_dict = new Dictionary<string, string>()
            {
                {"publicationDemographic", String.Join(",", publicationDemographic)},
                {"status", String.Join(",", status)},
                {"contentRating[]", String.Join(",", contentRating)}
            };

            return new Uri(QueryHelpers.AddQueryString(_config.MangaUri.ToString(),req_dict));
        }
    }
}
