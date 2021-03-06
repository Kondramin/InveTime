using InveTime.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace InveTime.Services
{
    static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IParserService, ParserService>()
            .AddTransient<IAutorisationService, AutorisationService>()
            ;
    }
}
