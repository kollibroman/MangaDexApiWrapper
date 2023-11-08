using System.Net.Http.Headers;
using MangaDexApiWrapper.Basic.Config;
using MangaDexApiWrapper.Basic.Infrastructure;
using MangaDexApiWrapper.Basic.Interfaces;
using MangaDexApiWrapper.Basic.RequestQueryBuilders;
using Microsoft.Extensions.DependencyInjection;

namespace MangaDexApiWrapper.Basic
{
    public static class DependencyInjection
    {
        public static void AddMangaDexWrapper(this IServiceCollection services)
        {
            services.AddScoped<ISearchQueryBuilder, SearchQueryBuilder>();
            services.AddScoped<ITagIdGetter, TagIdGetter>();
            services.AddSingleton<HttpClientConfig>();
            services.AddHttpClient("MangaClient", config =>
            {
                config.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });
        }
    }
}
