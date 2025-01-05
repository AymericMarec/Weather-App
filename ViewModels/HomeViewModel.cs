using Models;
using System;
using GetStartedApp.Views;
using System.Collections.Generic;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace GetStartedApp.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    private string _city;
    public string City
    {
        get { return _city; }
        set
        {
            _city = value;
            OnPropertyChanged(nameof(City));
        }
    }
    private string _currentTemp;
    public string CurrentTemp
    {
        get { return _currentTemp;}
        set
        {
            _currentTemp = value;
            OnPropertyChanged(nameof(CurrentTemp));
        }
    }

    private string _tempMax;
    public string TempMax
    {
        get { return _tempMax;}
        set
        {
            _tempMax = value;
            OnPropertyChanged(nameof(TempMax));
        }
    }

    private string _tempMin;
    public string TempMin
    {
        get { return _tempMin;}
        set
        {
            _tempMin = value;
            OnPropertyChanged(nameof(TempMin));
        }
    }

    private string _feelsLike;
    public string FeelsLike
    {
        get { return _feelsLike;}
        set
        {
            _feelsLike = value;
            OnPropertyChanged(nameof(FeelsLike));
        }
    }

    private string _humidity;
    public string Humidity
    {
        get { return _humidity;}
        set
        {
            _humidity = value;
            OnPropertyChanged(nameof(Humidity));
        }
    }

    private string _weatherDesc;
    public string WeatherDesc
    {
        get { return _weatherDesc;}
        set
        {
            _weatherDesc = value;
            OnPropertyChanged(nameof(WeatherDesc));
        }
    }

    private string _lat;
    public string Lat
    {
        get { return _lat;}
        set
        {
            _lat = value;
            OnPropertyChanged(nameof(Lat));
        }
    }

    private string _lon;
    public string Lon
    {
        get { return _lon;}
        set
        {
            _lon = value;
            OnPropertyChanged(nameof(Lon));
        }
    }

    private string _sunrise;
    public string Sunrise
    {
        get { return _sunrise;}
        set
        {
            _sunrise = value;
            OnPropertyChanged(nameof(Sunrise));
        }
    }

    private string _sunset;
    public string Sunset
    {
        get { return _sunset;}
        set
        {
            _sunset = value;
            OnPropertyChanged(nameof(Sunset));
        }
    }

    private Color _backgroundColor;
    public Color BackgroundColor
    {
        get { return _backgroundColor;}
        set
        {
            _backgroundColor = value;
            OnPropertyChanged(nameof(BackgroundColor));
        }
    }

    private Bitmap _todayWeatherIcon;
    public Bitmap TodayWeatherIcon
    {
        get { return _todayWeatherIcon;}
        set
        {
            _todayWeatherIcon = value;
            OnPropertyChanged(nameof(TodayWeatherIcon));
        }
    }

    private string _TempDay1;
    public string TempDay1
    {
        get { return _TempDay1;}
        set
        {
            _TempDay1 = value;
            OnPropertyChanged(nameof(TempDay1));
        }
    }
   private string _nameDay1;
    public string NameDay1
    {
        get { return _nameDay1;}
        set
        {
            _nameDay1 = value;
            OnPropertyChanged(nameof(NameDay1));
        }
    }
   private string _descriptionDay1;
    public string DescriptionDay1
    {
        get { return _descriptionDay1;}
        set
        {
            _descriptionDay1 = value;
            OnPropertyChanged(nameof(DescriptionDay1));
        }
    }
   private Bitmap _iconDay1;
    public Bitmap IconDay1
    {
        get { return _iconDay1;}
        set
        {
            _iconDay1 = value;
            OnPropertyChanged(nameof(IconDay1));
        }
    }


    private string _TempDay2;
    public string TempDay2
    {
        get { return _TempDay2;}
        set
        {
            _TempDay2 = value;
            OnPropertyChanged(nameof(TempDay2));
        }
    }
   private string _nameDay2;
    public string NameDay2
    {
        get { return _nameDay2;}
        set
        {
            _nameDay2 = value;
            OnPropertyChanged(nameof(NameDay2));
        }
    }
   private string _descriptionDay2;
    public string DescriptionDay2
    {
        get { return _descriptionDay2;}
        set
        {
            _descriptionDay2 = value;
            OnPropertyChanged(nameof(DescriptionDay2));
        }
    }
   private Bitmap _iconDay2;
    public Bitmap IconDay2
    {
        get { return _iconDay2;}
        set
        {
            _iconDay2 = value;
            OnPropertyChanged(nameof(IconDay2));
        }
    }

    private string _TempDay3;
    public string TempDay3
    {
        get { return _TempDay3;}
        set
        {
            _TempDay3 = value;
            OnPropertyChanged(nameof(TempDay3));
        }
    }
   private string _nameDay3;
    public string NameDay3
    {
        get { return _nameDay3;}
        set
        {
            _nameDay3 = value;
            OnPropertyChanged(nameof(NameDay3));
        }
    }
   private string _descriptionDay3;
    public string DescriptionDay3
    {
        get { return _descriptionDay3;}
        set
        {
            _descriptionDay3 = value;
            OnPropertyChanged(nameof(DescriptionDay3));
        }
    }
   private Bitmap _iconDay3;
    public Bitmap IconDay3
    {
        get { return _iconDay3;}
        set
        {
            _iconDay3 = value;
            OnPropertyChanged(nameof(IconDay3));
        }
    }

    private string _TempDay4;
    public string TempDay4
    {
        get { return _TempDay4;}
        set
        {
            _TempDay4 = value;
            OnPropertyChanged(nameof(TempDay4));
        }
    }
   private string _nameDay4;
    public string NameDay4
    {
        get { return _nameDay4;}
        set
        {
            _nameDay4 = value;
            OnPropertyChanged(nameof(NameDay4));
        }
    }
   private string _descriptionDay4;
    public string DescriptionDay4
    {
        get { return _descriptionDay4;}
        set
        {
            _descriptionDay4 = value;
            OnPropertyChanged(nameof(DescriptionDay4));
        }
    }
   private Bitmap _iconDay4;
    public Bitmap IconDay4
    {
        get { return _iconDay4;}
        set
        {
            _iconDay4 = value;
            OnPropertyChanged(nameof(IconDay4));
        }
    }

    private string _TempDay5;
    public string TempDay5
    {
        get { return _TempDay5;}
        set
        {
            _TempDay5 = value;
            OnPropertyChanged(nameof(TempDay5));
        }
    }
   private string _nameDay5;
    public string NameDay5
    {
        get { return _nameDay5;}
        set
        {
            _nameDay5 = value;
            OnPropertyChanged(nameof(NameDay5));
        }
    }
   private string _descriptionDay5;
    public string DescriptionDay5
    {
        get { return _descriptionDay5;}
        set
        {
            _descriptionDay5 = value;
            OnPropertyChanged(nameof(DescriptionDay5));
        }
    }
   private Bitmap _iconDay5;
    public Bitmap IconDay5
    {
        get { return _iconDay5;}
        set
        {
            _iconDay5 = value;
            OnPropertyChanged(nameof(IconDay5));
        }
    }




    private Bitmap _favIcon;
    public Bitmap FavIcon
    {
        get { return _favIcon; }
        set
        {
            _favIcon = value;
            OnPropertyChanged(nameof(FavIcon));
        }
    }

    private GetStartedApp.Views.Home _home;

    public HomeViewModel(GetStartedApp.Views.Home home)
    {
        _home = home;
        List<string> FavCity = Models.Settings.getFavCity();
        City = FavCity[0];
        UpdateFavIcon();
        DisplayInfos(); 
        

    }

    private void UpdateFavIcon()
    {
        List<string> favCities = Models.Settings.getFavCity();
        string imagePath = favCities.Contains(City) 
            ? "/Assets/img/FavOn.png" 
            : "/Assets/img/Fav.png";
    
        // Load image from embedded resource
        var uri = new Uri($"avares://GetStartedApp{imagePath}");
        FavIcon = new Bitmap(AssetLoader.Open(uri));
    }

    private Color UpdateBackgroundColor(char code)
    {
        if (code == 'd')
        {
            return Color.Parse("#FF57B8BF");
        }
        else
        {
            return Color.Parse("#FF171A52");
        }
    }

    public void HandleSearch(string searchText)
    {
        Console.WriteLine($"Recherche : {searchText}");
        this.City = searchText.Substring(0, 1).ToUpper() + searchText.Substring(1).ToLower();
        DisplayInfos();
        UpdateFavIcon();
            
    }


    public void DisplayInfos() {
        Models.WeatherResultDay result = Models.Api.GetInfoByNameToday(this.City, Models.Settings.getUnits(), Models.Settings.getLang());
        if (result == null) {
            _home.OpenNoInternet();
            return;
        }
        this.CurrentTemp = result.GetTemp();
        this.TempMax = result.GetTempMax();
        this.TempMin = result.GetTempMin();
        this.FeelsLike = "Ressenti : " + result.GetFeelsLike();
        this.Humidity = result.GetHumidity();
        this.WeatherDesc = result.GetWeatherDescription();
        this.Lat = result.GetLat();
        this.Lon = result.GetLon();
        this.Sunrise = result.GetSunrise();
        this.Sunset = result.GetSunset();
        this.TodayWeatherIcon = new Bitmap(result.GetWeatherIcon());
        this.BackgroundColor = UpdateBackgroundColor(result.GetDayOrNight());

        Models.WeatherResultWeek weekresult = Models.Api.GetInfoByName5Day(this.City, Models.Settings.getUnits(),Models.Settings.getLang());
        List<Tuple<string, WeatherResultDay>> WeatherWeek =  weekresult.GetDataMidTime();

        this.TempDay1 = WeatherWeek[0].Item2.GetTemp();
        this.NameDay1 = WeatherWeek[0].Item1;
        this.DescriptionDay1 = WeatherWeek[0].Item2.GetWeatherDescription();
        this.IconDay1 = new Bitmap(WeatherWeek[0].Item2.GetWeatherIcon());

        
        this.TempDay2 = WeatherWeek[1].Item2.GetTemp();
        this.NameDay2 = WeatherWeek[1].Item1;
        this.DescriptionDay2 = WeatherWeek[1].Item2.GetWeatherDescription();
        this.IconDay2 = new Bitmap(WeatherWeek[1].Item2.GetWeatherIcon());

        
        this.TempDay3 = WeatherWeek[2].Item2.GetTemp();
        this.NameDay3 = WeatherWeek[2].Item1;
        this.DescriptionDay3 = WeatherWeek[2].Item2.GetWeatherDescription();
        this.IconDay3 = new Bitmap(WeatherWeek[2].Item2.GetWeatherIcon());

        
        this.TempDay4 = WeatherWeek[3].Item2.GetTemp();
        this.NameDay4 = WeatherWeek[3].Item1;
        this.DescriptionDay4 = WeatherWeek[3].Item2.GetWeatherDescription();
        this.IconDay4 = new Bitmap(WeatherWeek[3].Item2.GetWeatherIcon());

        
        this.TempDay5 = WeatherWeek[4].Item2.GetTemp();
        this.NameDay5 = WeatherWeek[4].Item1;
        this.DescriptionDay5 = WeatherWeek[4].Item2.GetWeatherDescription();
        this.IconDay5 = new Bitmap(WeatherWeek[4].Item2.GetWeatherIcon());


    }

    public void ToggleFavorite()
    {
        List<string> favCities = Models.Settings.getFavCity();
        if (!favCities.Contains(City))
        {
            // On peut seulement ajouter une nouvelle ville favorite
            Models.Settings.AddFav(City);
            UpdateFavIcon();
        }
        // Si la ville est déjà en favori, on ne fait rien
    }
}
