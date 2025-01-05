using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace GetStartedApp {
    public class WeatherDescriptionToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string weatherDescription)
            {
                switch (weatherDescription.ToLower())
                {
                    case "Ciel dégagé":
                        return "/Assets/day_icon/Sun.png";
                    case "Nuageux" or "nuageux":
                        return "/Assets/day_icon/dayfewclouds.png";
                    case "pluie":
                        return "/Assets/day_icon/Rain.png";
                    case "orage":
                        return "/Assets/day_icon/Thunder.png";
                    default:
                        return "/Assets/day_icon/Default.png";
                }
            }
            return "/Assets/day_icon/dayfewclouds.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}