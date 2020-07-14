using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Wakaba2ChApiClient.Impl;
using Wakaba2ChApiClient.Interfaces;

namespace Wakaba2ChApiClient
{
    public static class WakabaServiceInjector
    {
        /// <summary>
        /// Заинжектить только API общего назначения
        /// </summary>
        /// <param name="services"></param>
        /// <param name="httpClientHandler">Http handler</param>
        /// <returns></returns>
        public static IServiceCollection AddWakaba2ChApi(this IServiceCollection services,
            HttpClientHandler httpClientHandler = null) =>
            services.AddSingleton<IWakaba2ChApi>(new Wakaba2ChApi(httpClientHandler));


        /// <summary>
        /// Заинжектить только мобильное API
        /// </summary>
        /// <param name="services"></param>
        /// <param name="httpClientHandler">Http handler</param>
        /// <returns></returns>
        public static IServiceCollection AddWakaba2ChApiMobile(this IServiceCollection services,
            HttpClientHandler httpClientHandler = null) =>
            services.AddSingleton<IWakaba2ChApiMobile>(new Wakaba2ChApiMobile(httpClientHandler));


        /// <summary>
        /// Заинжектить весь клитент
        /// </summary>
        /// <param name="services"></param>
        /// <param name="httpClientHandler">Http handler</param>
        /// <returns></returns>
        public static IServiceCollection AddWakaba2ChApiClient(this IServiceCollection services,
            HttpClientHandler httpClientHandler = null)
        {
            return services
                .AddWakaba2ChApi(httpClientHandler)
                .AddWakaba2ChApiMobile(httpClientHandler)
                .AddSingleton<IWakaba2ChApiClient>();
        }
    }
}