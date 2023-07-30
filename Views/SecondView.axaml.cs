using Avalonia.ReactiveUI;
using AvaRxUI.ViewModels;

namespace AvaRxUI.Views;

public partial class SecondView : ReactiveUserControl<SecondViewModel>
{
    public SecondView()
    {
        InitializeComponent();
    }
}