using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Ints
    {
        public static int MyMax(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int num;
            using (IEnumerator<int> enumerator = source.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                {
                    throw new ArgumentException("No max defined for an empty list");
                }

                num = enumerator.Current;
                while (enumerator.MoveNext())
                {
                    int current = enumerator.Current;
                    if (current > num)
                        num = current;
                }
            }

            return num;
        }
    }
}