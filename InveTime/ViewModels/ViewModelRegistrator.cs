using Microsoft.Extensions.DependencyInjection;

namespace InveTime.ViewModels
{
    static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<AutorisationWindowViewModel>()
            ;
    }
}
