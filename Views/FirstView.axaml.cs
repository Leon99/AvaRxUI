using Avalonia.ReactiveUI;
using AvaRxUI.ViewModels;

namespace AvaRxUI.Views;

public partial class FirstView : ReactiveUserControl<FirstViewModel>
{
    public FirstView()
    {
        InitializeComponent();
    }
}