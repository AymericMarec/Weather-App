using Avalonia.Controls;
using System.Linq;

namespace GetStartedApp.Views;

public partial class Settings : Window
{
    public Settings()
    {
        InitializeComponent();
        Language.ItemsSource = new string[]
            {"Français", "English"}
        .OrderBy(x => x);

        Unit.ItemsSource = new string[]
            {"Celsius", "Fahrenheit"}
        .OrderBy(x => x);
    }
} 