using FrwkBootCampQuickWait.Hospitals.Application.Consumers;
using FrwkBootCampQuickWait.Hospitals.Domain.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FrwkBootCampQuickWait.Hospitals.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection InjectHostedServices(this IServiceCollection services)
        {
            //services
            //    .AddHostedService<HospitalConsumer>();

            return services;
        }

        public static IServiceCollection InjectSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddSettings<DatabaseSettings>(configuration);

            return services;
        }

        private static IServiceCollection AddSettings<T>(this IServiceCollection services, IConfiguration configuration) where T : Settings, new()
        {
            services.Configure<T>(configuration.GetSection(typeof(T).Name));

            var settings = services.BuildServiceProvider().GetRequiredService<IOptions<T>>().Value;

            return services.AddSingleton(settings);
        }
    }
}