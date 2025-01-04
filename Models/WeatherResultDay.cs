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
        return this.Weather[0].Description;
    }
    public string GetWeatherIcon(){
        return this.Weather[0].Icon;
    }
    public double GetTemp(){
        return this.Main.Temp;
    }
    public double GetTempMax(){
        return this.Main.TempMax;
    }
    public double GetTempMin(){
        return this.Main.TempMin;
    }
    public int GetCloudiness(){
        return this.Clouds.All;
    }
    public int GetHumidity(){
        return this.Main.Humidity;
    }

}




