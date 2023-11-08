using System;
using MangaDexApiWrapper.Basic.Models.EntityModels;

namespace MangaDexApiWrapper.Basic.Interfaces
{
    public interface IMangaClient
    {
        public Task<List<Manga>> Search(string title);
        public Task<List<Manga>> TagSearch(string[] includedTag_ids, string[] excludedTag_ids);
        public Task<List<Manga>> TagSearchWithOrder(string[] includedTag_ids, string[] excludedTag_ids, string order, string followedCount);
        public Task<List<Manga>> DemographicOrContentRating(string[] publicationDemographic, string[] status, string[] contentRating);
    }
}
