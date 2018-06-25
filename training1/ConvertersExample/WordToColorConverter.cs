using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ConvertersExample
{
    [ValueConversion(typeof(string),typeof(SolidColorBrush))]
    public class WordToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string word = (string)value;
            SolidColorBrush brush = null;
            switch (word.ToLower())
            {
                case "hot" :
                    brush = new SolidColorBrush(Colors.Red);
                    break;
                case "cold":
                    brush = new SolidColorBrush(Colors.Green);
                    break;
                default:
                    brush = new SolidColorBrush(Colors.Yellow);
                    break;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = (SolidColorBrush)value;
            string word = string.Empty;
            string color = string.Empty;
            try
            {
                color = brush.Color.ToString().ToLower();
            }
            catch 
            {

                
            }
            switch (color)
            {
                case "#ffff0000":
                    word = "Hot";
                    break;
                case "green":
                    word = "cold";
                    break;
                default:
                    word = "normal";
                    break;
            }
            return word;

        }
    }
}
