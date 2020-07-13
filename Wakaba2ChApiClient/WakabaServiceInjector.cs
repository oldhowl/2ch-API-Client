using Microsoft.Extensions.DependencyInjection;

namespace Wakaba2ChApiClient
{
    public static class WakabaServiceInjector
    {
        public static IServiceCollection AddWakaba2ChApi(this IServiceCollection services) =>
            services.AddSingleton<IWakaba2ChApi, Wakaba2ChApi>();
    }
}