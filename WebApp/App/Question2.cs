using System;

namespace WebApp.App
{
    public class Question2
    {
        public string ReverseString(string value)
        {
            if (value == null)
            {
                throw new NullReferenceException("value cannot be null");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value cannot be empty");
            }

            var length = value.Length;
            var result = string.Empty;
            for (var i = 1; i <= length; i++)
            {
                result += value[length - i];
            }

            return result;
        }
    }
}
