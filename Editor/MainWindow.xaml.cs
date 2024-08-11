using System.Windows;
using Editor.GameProject;

namespace Editor;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnMainWindowsLoaded;
    }

    private void OnMainWindowsLoaded(object sender, RoutedEventArgs e)
    {
        Loaded -= OnMainWindowsLoaded;
        OpenProjectBrowserDialog();
    }

    private void OpenProjectBrowserDialog()
    {
        var projectBrowser = new ProjectBrowserDialog();

        if (projectBrowser.ShowDialog() == false)
        {
            Application.Current.Shutdown();
        }
    }
}