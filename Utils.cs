using System;

namespace OMSDataManager
{
    public static class Utils
    {
        public static T? GetStructNullValue<T>(string v) where T : struct
        {
            if (string.IsNullOrEmpty(v))
            {
                return null;
            }

            T result = default;

            try
            {
                result = (T)Convert.ChangeType(v.Replace(".", ","), typeof(T));
            }
            catch (Exception)
            {
                Console.WriteLine($"Error in {v} for {typeof(T).Name}");

            }

            return result;
        }

        public static string GetBoolValue(string value)
        {
            switch (value)
            {
                case "false":
                    return "0";
                case "true":
                    return "1";
                default:
                    Console.WriteLine($"Error in {value} when converting to bool. Returning null.");
                    return null;
            }
        }
    }
}
