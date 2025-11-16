using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsApplication.Data
{
    internal class AgeConverter : IValueConverter
    {
        string[] gradientColorList = [
            "#75f414", // green, 20
            "#95df00",
            "#acca00",
            "#bbb500",
            "#c79f00",
            "#ce8800",
            "#d17100",
            "#d05a00",
            "#cb4115",
            "#c32626"]; //red, 80

        int bottomVal = 20;
        int topVal = 80;
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float val = 33f;

            int range = bottomVal - topVal;
            float step = (float) range / gradientColorList.Length;
            //float groundVal = val - bottomValue;
            for (int i = 0; i < gradientColorList.Length; i++)
            {
                float calcVal = bottomVal + (i * step);
                if (val <= calcVal)
                {
                    return gradientColorList[i];
                }
            }
            return gradientColorList.Last();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
