using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
