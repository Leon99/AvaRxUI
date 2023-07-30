using System;
using ReactiveUI;

namespace AvaRxUI.ViewModels;

public class FirstViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString()[..5];

    public FirstViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}