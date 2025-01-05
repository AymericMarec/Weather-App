using Models;
using System;
using System.Collections.Generic;
using Avalonia.Media;


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
    public HomeViewModel()
    {
        List<string> FavCity = Settings.getFavCity();
        City = FavCity[0];
        DisplayInfos(); 
    }


    private Color UpdateBackgroundColor()
    {
        DateTime currentTime = DateTime.Now;
        TimeSpan sunriseTime = TimeSpan.Parse(Sunrise);
        TimeSpan sunsetTime = TimeSpan.Parse(Sunset);

        if (currentTime.TimeOfDay >= sunriseTime && currentTime.TimeOfDay <= sunsetTime)
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
            this.City = searchText.Substring(0, 1).ToUpper() + searchText.Substring(1).ToLower();;
            DisplayInfos();
    }

    public void DisplayInfos() {
        Models.WeatherResultDay result = Models.Api.GetInfoByNameToday(this.City);
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
        this.BackgroundColor = UpdateBackgroundColor();
    }


    // Console.WriteLine("coucou");
}
