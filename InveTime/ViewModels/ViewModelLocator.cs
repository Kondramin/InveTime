using Microsoft.Extensions.DependencyInjection;

namespace InveTime.ViewModels
{
    class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => App.Services.GetRequiredService<MainWindowViewModel>();
        public AutorisationWindowViewModel AutorisationWindowViewModel => App.Services.GetRequiredService<AutorisationWindowViewModel>();

    }
}
