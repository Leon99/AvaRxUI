using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaRxUI.ViewModels;
using AvaRxUI.Views;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;

namespace AvaRxUI;

public partial class App : Application
{
    internal static void ConfigureServices(IServiceCollection services)
    {
        // Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
        // Locator.CurrentMutable.Register(() => new FirstViewModel(Locator.Current.GetService<MainWindowViewModel>()!));
        services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<IScreen, MainWindowViewModel>(x => x.GetRequiredService<MainWindowViewModel>())
            
            .AddSingleton<IViewFor<FirstViewModel>, FirstView>()
            .AddSingleton<FirstViewModel>()
            
            .AddSingleton<IViewFor<SecondViewModel>, SecondView>()
            .AddSingleton<SecondViewModel>()
            ;
    }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}