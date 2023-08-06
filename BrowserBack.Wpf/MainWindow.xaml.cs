using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using AvaRxUI.Views;

namespace BrowserBack.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        protected override void OnPreviewKeyUp(KeyEventArgs e)
        {
            Debug.WriteLine(e.Key);
            base.OnPreviewKeyUp(e);
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine(e.Command);
        }
    }
}