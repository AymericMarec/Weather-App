using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Models;


public class WeatherResultDay
{
    public Coord Coord { get; set; }
    public List<Weather> Weather { get; set; }
    public string Base { get; set; }
    public Main Main { get; set; }
    public int Visibility { get; set; }
    public Wind Wind { get; set; }
    public Rain Rain { get; set; }
    public Clouds Clouds { get; set; }
    public int Dt { get; set; }
    public Sys Sys { get; set; }
    public int Timezone { get; set; }
    public string Name { get; set; }

    public string GetWeather(){
        return this.Weather[0].Main;
    }
    public string GetWeatherDescription(){
        string desc = this.Weather[0].Description;
        return char.ToUpper(desc[0]) + desc.Substring(1);

    }
    public string GetWeatherIcon(){
        return this.Weather[0].Icon;
    }
    public string GetTemp(){
        return Math.Round(this.Main.Temp).ToString() + "°c";
    }
    public string GetTempMax(){
        Console.WriteLine(this.Main.Temp_Max);
        return Math.Round(this.Main.Temp_Max).ToString() + "°c";
    }
    public string GetTempMin(){
        return Math.Round(this.Main.Temp_Min).ToString() + "°c";
    }

    public string GetFeelsLike(){
        return Math.Round(this.Main.Feels_Like).ToString() + "°c";
    }
    public string GetHumidity(){
        return this.Main.Humidity.ToString() + "%";
    }

    public string GetLat(){
        return Math.Round(this.Coord.Lat, 2).ToString() + "° N";
    }
    
    public string GetLon(){
        return Math.Round(this.Coord.Lon, 2).ToString() + "° E";
    }

    public string GetSunrise(){
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds( this.Sys.Sunrise ).ToLocalTime();
        return dateTime.ToString("HH:mm");
    }

    public string GetSunset(){
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds( this.Sys.Sunset ).ToLocalTime();
        return dateTime.ToString("HH:mm");
    }


}




