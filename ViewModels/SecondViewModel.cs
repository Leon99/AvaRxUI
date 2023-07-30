using System;
using ReactiveUI;

namespace AvaRxUI.ViewModels;

public class SecondViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = Guid.NewGuid().ToString()[..5];

    public SecondViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}