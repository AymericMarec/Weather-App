using System;
using System.Net.Http;
using DotNetEnv;
using Newtonsoft.Json;

namespace Models;

public static class Api{
    public static WeatherResultDay GetInfoByNameToday(string CityName,string units="metric",string lang="fr"){
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={CityName}&appid={apiKey}&units={units}&lang={lang}";
        string data = FetchApiData(apiUrl);
        if (data == null)
        {
            Console.WriteLine("Erreur : Pas d'internet ou autre problème de connexion.");
            return null;
        }
        WeatherResultDay WeatherResultDay = JsonConvert.DeserializeObject<WeatherResultDay>(data);
        Console.WriteLine(data);
        return WeatherResultDay;
    }
    public static WeatherResultWeek GetInfoByName5Day(string CityName,string units="metric",string lang="fr"){
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={CityName}&appid={apiKey}&units={units}&lang={lang}";
        string data = FetchApiData(apiUrl);
        if (data == null)
        {
            Console.WriteLine("Erreur : Pas d'internet ou autre problème de connexion.");
            return null;
        }
        WeatherResultWeek WeatherResultWeek = JsonConvert.DeserializeObject<WeatherResultWeek>(data);
        Console.WriteLine(data);
        return WeatherResultWeek;
    }

    private static string FetchApiData(string apiUrl)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result; 
                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result; 
                    return responseData;
                }
                else
                {
                    Console.WriteLine($"Erreur : Statut HTTP {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la requête : {e.Message}");
                return null;
            }
        }
    }

}