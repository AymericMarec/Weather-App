using Models;
using System;
using System.Collections.Generic;

namespace GetStartedApp.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    public string Greeting { get; }
    public HomeViewModel()
    {
        List<string> FavCity = Settings.getFavCity();
        Greeting = FavCity[0];

        //how to print all Weather for each fav city every 3 hours
        // for(int i = 0 ; i < FavCity.Count;i++){
        //     string city = FavCity[i];
        //     Models.WeatherResultWeek result = Models.Api.GetInfoByName5Day(city);
        //     for(int j = 0; j < result.List.Count;j++){
        //         Console.WriteLine(result.List[j].GetWeather());
        //     }
        // }
    }
    // Console.WriteLine("coucou");
}
