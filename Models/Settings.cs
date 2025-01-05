using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;


namespace Models;

public class Settings{
    public string Lang{ get; set; }
    public List<string> FavCity{ get; set; }
    public string Units{ get; set; }
    protected static string path ="options.json";

    public Settings(){
        if(!File.Exists(path)){
            this.Lang = "fr";
            this.FavCity = new List<string> { "Paris" };
            this.Units = "metric"; 
            string jsonContent = JsonSerializer.Serialize(this);
            using(StreamWriter writetext = new StreamWriter(path)){
                writetext.WriteLine(jsonContent);
            }
        }
    }
    private static Settings getInfoFile(){
        string options;
        using(StreamReader readtext = new StreamReader(path)){
            options = readtext.ReadLine();
        }
        Settings settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(options);
        return settings;
    }
    public static string getLang(){
        Settings settings = getInfoFile();
        return settings.Lang;
    }
    public static List<string> getFavCity(){
        Settings settings = getInfoFile();
        return settings.FavCity;
    }

    private static void ChangeFile(Settings settings){
        string jsonContent = JsonSerializer.Serialize(settings);
        using(StreamWriter writetext = new StreamWriter(path)){
            writetext.WriteLine(jsonContent);
        }
    }

    public static void changeLang(string lang){
        Settings settings = getInfoFile();
        settings.Lang = lang;
        ChangeFile(settings);
    }

    public static void changeUnits(string units){
        Settings settings = getInfoFile();
        settings.Units = units;
        ChangeFile(settings);
    }

    public static void AddFav(string city){
        Settings settings = getInfoFile();
        settings.FavCity.Add(city);
        ChangeFile(settings);
    }

    public static void RemoveFav(string city){
        Settings settings = getInfoFile();
        settings.FavCity.Remove(city);
        ChangeFile(settings);
    }

    public static string getUnits()
    {
        Settings settings = getInfoFile();
        return settings.Units;
    }

}