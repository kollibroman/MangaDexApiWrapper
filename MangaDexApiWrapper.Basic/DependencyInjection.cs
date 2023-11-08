using MangaDexApiWrapper.Auth;
using System.Net.Http.Headers;
using MangaDexApiWrapper.Basic.Config;
using MangaDexApiWrapper.Basic.Infrastructure;
using MangaDexApiWrapper.Basic.Interfaces;
using MangaDexApiWrapper.Basic.RequestQueryBuilders;
using Microsoft.Extensions.DependencyInjection;
using MangaDexApiWrapper.Auth.Response;

namespace MangaDexApiWrapper.Basic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMangaDexWrapper(this IServiceCollection services)
        {
            services.AddAuth();
            services.AddScoped<ISearchQueryBuilder, SearchQueryBuilder>();
            services.AddScoped<ITagIdGetter, TagIdGetter>();
            services.AddSingleton<HttpClientConfig>();
            services.AddHttpClient("MangaClient", config =>
            {
                config.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            return services;
        }
    }
}
