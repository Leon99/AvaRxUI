using System.Reflection;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaRxUI.ViewModels;
using AvaRxUI.Views;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using Splat;

namespace AvaRxUI;

public partial class App : Application
{
    public App()
    {
        Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
        Locator.CurrentMutable.Register(() => new MainWindowViewModel());
    }

    internal static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<IScreen, MainWindowViewModel>(x => x.GetRequiredService<MainWindowViewModel>())
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