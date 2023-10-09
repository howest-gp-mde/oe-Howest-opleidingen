using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SP.Converters
{
    public class LocationToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;


            if (value.ToString() == "Kortrijk")
            {
                return "https://d21buns5ku92am.cloudfront.net/69252/images/376305-01_Kortrijk-logo-web_ROOD-pos-682433-medium-1610974902.png";
            }
            else
            {
                return "https://image.shutterstock.com/image-photo/image-260nw-2321158095.jpg";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
