using System;
using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaRxUI.Views;

public class MainWindowViewModel : ReactiveObject
{
    public ReactiveCommand<string, Unit> LogKeyCommand { get; }

    [Reactive]
    public string Log { get; set; }

    public MainWindowViewModel()
    {
        LogKeyCommand = ReactiveCommand.Create<string>(s =>
        {
            Log += s + Environment.NewLine;
        });
    }
}