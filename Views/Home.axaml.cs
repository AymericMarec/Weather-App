using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;
using System;
using Models;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class Home : Window
{

    public Home()
    {
        InitializeComponent();
    }

    private void ChangeFav(object? sender, RoutedEventArgs e) {
        var homeViewModel = DataContext as HomeViewModel;
        Models.Settings.RemoveFav();
        Models.Settings.AddFav(homeViewModel.City);
    }

    private async void OpenSettings(object sender, RoutedEventArgs e)
    {
        var homeViewModel = DataContext as HomeViewModel;
        var settingsWindow = new Settings(homeViewModel)
        {
            DataContext = new ViewModels.SettingsViewModel()
        };
        
        await settingsWindow.ShowDialog(this); // Shows settings as a modal dialog
    }

    private void TextBox_KeyDown(object? sender, KeyEventArgs e) {
        if (e.Key == Key.Enter && sender is TextBox textBox) {
            string searchText = textBox.Text;
            if (!string.IsNullOrWhiteSpace(searchText)) {
                var viewModel = DataContext as HomeViewModel;
                viewModel?.HandleSearch(searchText);
            }
        }
    }
}