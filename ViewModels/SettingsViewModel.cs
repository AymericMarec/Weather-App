namespace GetStartedApp.ViewModels;
using System.Collections.ObjectModel;

public class SettingsViewModel : ViewModelBase
{
    private string _selectedLanguage;
    private string _selectedUnit;
    public ObservableCollection<string> Languages { get; } = new() { "Français", "English" };
    public ObservableCollection<string> Units { get; } = new() { "Celsius", "Fahrenheit" };

    public string SelectedLanguage
    {
        get => _selectedLanguage;
        set
        {
            if (SetProperty(ref _selectedLanguage, value))
            {
                string lang = value == "Français" ? "fr" : "en";
                Models.Settings.changeLang(lang);
            }
        }
    }

    public string SelectedUnit
    {
        get => _selectedUnit;
        set
        {
            if (SetProperty(ref _selectedUnit, value))
            {
                string units = value == "Celsius" ? "metric" : "imperial";
                Models.Settings.changeUnits(units);
            }
        }
    }

    public SettingsViewModel()
    {
        string currentLang = Models.Settings.getLang();
        SelectedLanguage = currentLang == "fr" ? "Français" : "English";

        string currentUnits = Models.Settings.getUnits(); 
        SelectedUnit = currentUnits == "metric" ? "Celsius" : "Fahrenheit";
    }
} 