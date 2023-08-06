using System;
using Avalonia.Input;
using Avalonia.ReactiveUI;

namespace AvaRxUI.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        LogTextBox.Text += e.KeyModifiers + "+" + e.Key + Environment.NewLine;
        base.OnKeyUp(e);
    }
}