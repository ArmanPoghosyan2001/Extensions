using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    static class Extensions
    {
        public static bool TryGetWordFromThird(this string source, out string response)
        {
            response = null;
            bool hasValue = false;
            for (int i = 2; i < source.Length; i += 3)
            {
                response += source[i];
                hasValue = true;
            }
            return hasValue;
        }

  
        public static string FirstAndLast(this string source)
        {
            return (source[0] + source[source.Length - 1]).ToString();
        }
        public static bool GetSumOfOddElements(this IEnumerable<int> source,out int response)
        {
            bool hasValue = false;
            response = 0;
            foreach (int item in source)
            {
                if (item%2==1)
                {
                    response += item;
                    hasValue = true;
                }
            }
            if (!hasValue)
            {
                response = default(int);
            }
            return hasValue;
        }
        public static bool _IsNullOrEmpty<T>(this List<T> source)
        {
            return !source.Any();
        }
        public static int GetMiddleElement(this List<int> source)
        {
            return source[source.Count / 2];
        }
    }
}
