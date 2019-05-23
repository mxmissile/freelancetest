using System;
using System.Globalization;

namespace WebApp.App
{
    public class Question1
    {
        public DateTime GetDate(int value)
        {
            const string format = "yyyyMMdd";
            var formatProvider = new CultureInfo("en-US").DateTimeFormat;

            if (DateTime.TryParseExact(value.ToString(), format, formatProvider, DateTimeStyles.None, out var result))
            {
                return result;
            }

            throw new FormatException("invalid date format");
        }
    }
}
