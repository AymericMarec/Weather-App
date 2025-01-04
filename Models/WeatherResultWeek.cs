using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Models;

public class WeatherResultWeek
{

    public string Cod { get; set; }
    public int Message { get; set; }
    public int cnt { get; set; }
    public List<WeatherResultDay> List { get; set; }
    public City City { get; set; }

    public Dictionary<string, WeatherResultDay> GetDataMidTime(){
        Dictionary<string, WeatherResultDay> Weather = new Dictionary<string, WeatherResultDay>();
        foreach(WeatherResultDay weather in List){
            int Time = weather.Dt;
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(Time).DateTime;
            string dayName = dateTime.ToString("dddd");
            string hour = dateTime.ToString("HH");
            if(hour == "12"){
                Console.WriteLine(dayName+" : "+weather.GetTemp());
                Weather.Add(dayName,weather);
            }
        }
        return Weather;
    }
}