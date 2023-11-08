using System;

namespace MangaDexApiWrapper.Basic.Interfaces
{
    public interface ISearchQueryBuilder
    {
        public Uri BasicSearch(string title);
        public Uri TagSearch(string[] includedTag_ids, string[] excludedTag_ids);
        public Uri TagSearchWithOrder(string[] includedTag_ids, string[] excludedTag_ids, string order, string followedCount);
        public Uri DemographicOrContentRating(string[] publicationDemographic, string[] status, string[] contentRating);
    }
}
