using System;
using System.Linq;
using System.Net.Http.Headers;
using MangaDexApiWrapper.Basic.Config;
using MangaDexApiWrapper.Basic.Interfaces;
using MangaDexApiWrapper.Basic.Models.EntityModels;
using MangaDexApiWrapper.Basic.Models.Response;

namespace MangaDexApiWrapper.Basic.Infrastructure
{
    public class TagIdGetter : ITagIdGetter
    {
        private readonly HttpClientConfig _config;
        public TagIdGetter(HttpClientConfig config)
        {
            _config = config;
        }

        public async Task<string[]> GetIdArray(string[] names)
        {
            var tagList = new List<Tag>();
            List<string> id_list = new();
            using(var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await httpclient.GetAsync(_config.TagListUri);
                var responseStr = await response.Content.ReadAsStringAsync();
                
                var tagResponse = JsonConvert.DeserializeObject<NormalResponse<List<Tag>>>(responseStr);
                tagList = tagResponse.Data;
            }

            for(int i = 0; i < names.Length; i++)
            {
                var tag = tagList.SingleOrDefault(tag => tag.TagAttributes.Name == names[i]);
                id_list.Add(tag.Id.ToString());
            }

            return id_list.ToArray();
        }
    }
}
