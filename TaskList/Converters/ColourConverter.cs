using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Converters
{
    public class ColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var colour = value.ToString();
            return Color.FromArgb(colour);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo Culture) 
        { 
            throw new NotImplementedException();
        }
    }
}
