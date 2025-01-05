using Models;
using System;
using System.Collections.Generic;
using Avalonia.Media;

namespace GetStartedApp.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    public string City { get; }
    public string CurrentTemp { get; }
    public string TempMax { get; }
    public string TempMin { get; }
    public string FeelsLike { get; }
    public string Humidity { get; }
    public string WeatherDesc { get; }
    public string Lat { get; }
    public string Lon { get; }
    public string Sunrise { get; }
    public string Sunset { get; }
    public HomeViewModel()
    {
        List<string> FavCity = Settings.getFavCity();
        City = FavCity[0];
        Models.WeatherResultDay result = Models.Api.GetInfoByNameToday(City);

        CurrentTemp = result.GetTemp();
        TempMax = result.GetTempMax();
        TempMin = result.GetTempMin();
        FeelsLike = "Ressenti : " + result.GetFeelsLike();
        Humidity = result.GetHumidity();
        WeatherDesc = result.GetWeatherDescription();
        Lat = result.GetLat();
        Lon = result.GetLon();
        Sunrise = result.GetSunrise();
        Sunset = result.GetSunset();
        BackgroundColor = UpdateBackgroundColor();
        Console.WriteLine(BackgroundColor);

        

        //how to print all Weather for each fav city every 3 hours
        // for(int i = 0 ; i < FavCity.Count;i++){
        //     string city = FavCity[i];
        //     
        //     for(int j = 0; j < result.List.Count;j++){
        //         Console.WriteLine(result.List[j].GetWeather());
        //     }
        // }
    }


    private Color _backgroundColor;
    public Color BackgroundColor 
    {
        get => _backgroundColor;
        set
        {
            _backgroundColor = value;
            OnPropertyChanged(nameof(BackgroundColor));
        }
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


    // Console.WriteLine("coucou");
}
