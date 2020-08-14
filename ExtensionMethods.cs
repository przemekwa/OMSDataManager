using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OMSDataManager
{
    public static class ExtensionMethods
    {
        public  static string[] SplitWithDoubleQuots(this string line, char spliter)
        {
            var result = new List<string>();

            StringBuilder currentStr = new StringBuilder("");

            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++) 
            {
                if (line[i] == '\"')
                {
                    inQuotes = !inQuotes;
                }
                else if (line[i] == spliter) 
                {
                    if (!inQuotes) 
                    {
                        result.Add(currentStr.ToString());
                        currentStr.Clear();
                    }
                    else
                    {
                        currentStr.Append(line[i]); 
                    }
                }
                else
                {
                    currentStr.Append(line[i]);
                }
            }

            result.Add(currentStr.ToString());
            
            return result.ToArray(); 
        }


        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] array, int size)
        {
            if (array.Length == 0 || size == 0)
            {
                yield return array;
            }

            for (var i = 0; i < (float)array.Length / size; i++)
            {
                yield return array.Skip(i * size).Take(size);
            }
        }

        public static IEnumerable<IEnumerable<T>> Split<T>(this IList<T> list, int size)
        {
            if (list.Count == 0 || size == 0)
            {
                yield return list;
            }

            for (var i = 0; i < (float)list.Count / size; i++)
            {
                yield return list.Skip(i * size).Take(size);
            }

        }

        public static IEnumerable<IEnumerable<T>> SplitInToParts<T>(this IList<T> source, short parts)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Count == 0)
            {
                throw new InvalidOperationException("Source cannot be empty");
            }

            if (parts == 0)
            {
                throw new ArgumentException("Cannot divide by zero.", "parts");
            }

            var totalRows = source.Count;

            var skipRows = 0;

            var takeRows = totalRows / parts;

            for (var part = 0; part < parts; part++)
            {
                var partialList = new List<T>();

                partialList.AddRange(source.Skip(skipRows).Take(takeRows));

                skipRows += takeRows;

                if (part == parts - 2)
                {
                    takeRows = totalRows - skipRows;
                }

                yield return partialList;
            }
        }
    }
}
