using System;
using MangaDexApiWrapper.Basic.Interfaces;
using MangaDexApiWrapper.Basic.Models.EntityModels;
using MangaDexApiWrapper.Basic.Models.Response;

namespace MangaDexApiWrapper.Basic.Client
{
    public class MangaClient : IMangaClient
    {
        private readonly ISearchQueryBuilder _builder;
        private readonly ITagIdGetter _idGetter;
        private readonly IHttpClientFactory _client;
        public MangaClient(ISearchQueryBuilder builder, ITagIdGetter tagIdGetter, IHttpClientFactory httpClientFactory)
        {
            _builder = builder;
            _idGetter = tagIdGetter;    
            _client = httpClientFactory;
        }
        /// <summary>
        /// Basic search for manga with given title
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Manga with given title</returns>
        public async Task<List<Manga>> Search(string title)
        {
            var client = _client.CreateClient("MangaClient");
            var request = await client.GetAsync(_builder.BasicSearch(title));

            var response = JsonConvert.DeserializeObject<NormalResponse<List<Manga>>>(await request.Content.ReadAsStringAsync());
            return response.Data;
        }
        
        public async Task<List<Manga>> TagSearch(string[] includedTag_ids, string[] excludedTag_ids)
        {
            var client = _client.CreateClient("MangaClient");
            var request = await client.GetAsync(_builder.TagSearch(await _idGetter.GetIdArray(includedTag_ids), 
            await _idGetter.GetIdArray(excludedTag_ids)));

            var response = JsonConvert.DeserializeObject<NormalResponse<List<Manga>>>(await request.Content.ReadAsStringAsync());
            return response.Data;
        }

        public async Task<List<Manga>> TagSearchWithOrder(string[] includedTag_ids, string[] excludedTag_ids, string order, string followedCount)
        {
            var client = _client.CreateClient("MangaClient");
            var request = await client.GetAsync(_builder.TagSearchWithOrder(await _idGetter.GetIdArray(includedTag_ids),
             await _idGetter.GetIdArray(excludedTag_ids), order,followedCount));

            var response = JsonConvert.DeserializeObject<NormalResponse<List<Manga>>>(await request.Content.ReadAsStringAsync());
            return response.Data;
        }

        public async Task<List<Manga>> DemographicOrContentRating(string[] publicationDemographic, string[] status, string[] contentRating)
        {
            var client = _client.CreateClient("MangaClient");
            var request = await client.GetAsync(_builder.DemographicOrContentRating(publicationDemographic, status, contentRating));

            var response = JsonConvert.DeserializeObject<NormalResponse<List<Manga>>>(await request.Content.ReadAsStringAsync());
            return response.Data;
        }
    }
}
