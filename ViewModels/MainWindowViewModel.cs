using System;
using System.Reactive;
using ReactiveUI;
using Splat;

namespace AvaRxUI.ViewModels;

public class MainWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; }

    public ReactiveCommand<Unit, IRoutableViewModel> GoFirst { get; }
    public ReactiveCommand<Unit, IRoutableViewModel> GoSecond { get; }
    public ReactiveCommand<Unit, IRoutableViewModel?> GoBack => Router.NavigateBack;

    public MainWindowViewModel()
    {
        Router = new RoutingState();
        GoFirst = ReactiveCommand.CreateFromObservable(NavigateTo<FirstViewModel>, Router.Navigate.CanExecute);
        GoSecond = ReactiveCommand.CreateFromObservable(NavigateTo<SecondViewModel>, Router.Navigate.CanExecute);
    }

    private IObservable<IRoutableViewModel> NavigateTo<T>() where T:IRoutableViewModel
    {
        return Router.Navigate.Execute(Locator.Current.GetService<T>());
    }
}