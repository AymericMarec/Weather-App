﻿using Models;
using System;
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

    public HomeViewModel()
    {
        List<string> FavCity = Settings.getFavCity();
        City = FavCity[0];
        UpdateFavIcon();
        DisplayInfos(); 
    }

    private void UpdateFavIcon()
    {
        List<string> favCities = Settings.getFavCity();
        string imagePath = favCities.Contains(City) 
            ? "/Assets/img/FavOn.png" 
            : "/Assets/img/Fav.png";
        
        // Load image from embedded resource
        var uri = new Uri($"avares://GetStartedApp{imagePath}");
        FavIcon = new Bitmap(AssetLoader.Open(uri));
    }

    private Color UpdateBackgroundColor(char code)
    {
        Console.WriteLine(code);
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
        Models.WeatherResultDay result = Models.Api.GetInfoByNameToday(this.City, Settings.getUnits(),Settings.getLang());
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
    }

    public void ToggleFavorite()
    {
        List<string> favCities = Settings.getFavCity();
        if (favCities.Contains(City))
        {
            Settings.RemoveFav(City);
        }
        else
        {
            Settings.AddFav(City);
        }
        UpdateFavIcon();
    }
}
