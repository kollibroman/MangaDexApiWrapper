using System;
using MangaDexApiWrapper.Auth.Clients;
using MangaDexApiWrapper.Auth.Config;
using MangaDexApiWrapper.Auth.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MangaDexApiWrapper.Auth
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuth(this IServiceCollection services)
        {
            services.AddSingleton<HttpClientConfig>();
            services.AddScoped<ILoginClient, LoginClient>();
            return services;
        }
    }
}
