using Avalonia;
using System;
using DotNetEnv;
using Models;

namespace GetStartedApp;

sealed class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Env.Load();                 // Loading .env file to get the api key
        new Models.Settings();      // Init Settings file if doesnt exist

        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
