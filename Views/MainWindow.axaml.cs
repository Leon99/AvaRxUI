using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaRxUI.ViewModels;
using ReactiveUI;

namespace AvaRxUI.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}