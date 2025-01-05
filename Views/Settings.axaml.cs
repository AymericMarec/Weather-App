using Avalonia.Controls;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;
using System;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class Settings : Window
{
    private HomeViewModel _homeViewModel;
    public Settings(HomeViewModel homeViewModel)
    {
        _homeViewModel = homeViewModel;

        InitializeComponent();
        Language.ItemsSource = new string[]
            {"Français", "English"}
        .OrderBy(x => x);

        Unit.ItemsSource = new string[]
            {"Celsius", "Fahrenheit"}
        .OrderBy(x => x);
    }

    private void CloseSettings(object sender, RoutedEventArgs e) {
        _homeViewModel.DisplayInfos();
        this.Close();
    }

} 