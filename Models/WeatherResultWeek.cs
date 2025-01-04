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

}