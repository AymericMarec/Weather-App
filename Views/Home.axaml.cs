using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GetStartedApp.Views;

public partial class Home : Window
{
    public Home()
    {
        InitializeComponent();
    }

    private async void OpenSettings(object sender, RoutedEventArgs e)
    {
        var settingsWindow = new Settings
        {
            DataContext = new ViewModels.SettingsViewModel()
        };
        
        await settingsWindow.ShowDialog(this); // Shows settings as a modal dialog
    }
}